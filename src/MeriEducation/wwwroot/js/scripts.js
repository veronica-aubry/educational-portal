$(document).ready(function () {
    $("#SkinId").change(function () {
        $('#skin').html("<img src='/images/skin/" + this.value + ".png'/>")
    });
});

function addQuestion() {
    $('#questions').append($('.questionsForm').clone());
}
