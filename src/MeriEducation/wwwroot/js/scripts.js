
//Avatar Create Page

$(document).ready(function () {
    $("#hairId").change(function () {
        $('#hair').html("<img src='/images/hair/" + this.value + ".png'/>")
    });
    $("#skinId").change(function () {
        $('#skin').html("<img src='/images/skin/" + this.value + ".png'/>")
    });
    $("#outfitId").change(function () {
        $('#outfits').html("<img src='/images/outfit/" + this.value + ".png'/>")
    });
});


//Vocab interact scripts

interact('.draggable')
  .draggable({
      inertia: true,
      autoScroll: true,
      onmove: dragMoveListener
  });


function dragMoveListener(event) {
    var target = event.target,
        // keep the dragged position in the data-x/data-y attributes
        x = (parseFloat(target.getAttribute('data-x')) || 0) + event.dx,
        y = (parseFloat(target.getAttribute('data-y')) || 0) + event.dy;

    // translate the element
    target.style.webkitTransform =
    target.style.transform =
      'translate(' + x + 'px, ' + y + 'px)';

    // update the posiion attributes
    target.setAttribute('data-x', x);
    target.setAttribute('data-y', y);
}

// this is used later in the resizing and gesture demos
window.dragMoveListener = dragMoveListener;

interact('.dropzone').dropzone({
    accept: '.yes-drop',
    overlap: 0.75,
    ondropactivate: function (event) {
        event.target.classList.add('drop-active');
    },
    ondragenter: function (event) {
        var draggableElement = event.relatedTarget,
            dropzoneElement = event.target;
        dropzoneElement.classList.add('drop-target');
        draggableElement.classList.add('can-drop');
        if ($(draggableElement).hasClass(dropzoneElement.id)) {
            draggableElement.classList.add('right');
        } else {
            draggableElement.classList.add('wrong');
        };
    },
    ondragleave: function (event) {
        event.target.classList.remove('drop-target');
        event.relatedTarget.classList.remove('can-drop');
        event.relatedTarget.classList.remove('right');
        event.relatedTarget.classList.remove('wrong');
    },
    ondropdeactivate: function (event) {
        event.target.classList.remove('drop-active');
        event.target.classList.remove('drop-target');
    }
});

$(function () {
    $('button').click(function () {
        $(".drag-drop.right").css('background-color', 'green');
        $(".drag-drop.wrong").css('background-color', 'orangered');
    });
});
