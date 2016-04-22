using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MeriEducation.Models;

namespace MeriEducation.Migrations
{
    [DbContext(typeof(MeriEducationContext))]
    partial class MeriEducationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeriEducation.Models.Avatar", b =>
                {
                    b.Property<int>("AvatarId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("genderId");

                    b.Property<int>("skinId");

                    b.HasKey("AvatarId");

                    b.HasAnnotation("Relational:TableName", "Avatars");
                });

            modelBuilder.Entity("MeriEducation.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("answer1");

                    b.Property<string>("answer2");

                    b.Property<string>("answer3");

                    b.Property<string>("answer4");

                    b.Property<string>("correctAnswer");

                    b.Property<string>("questionText");

                    b.Property<int>("quizId");

                    b.HasKey("QuestionId");

                    b.HasAnnotation("Relational:TableName", "Questions");
                });

            modelBuilder.Entity("MeriEducation.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("grade");

                    b.Property<string>("name");

                    b.HasKey("QuizId");

                    b.HasAnnotation("Relational:TableName", "Quizes");
                });

            modelBuilder.Entity("MeriEducation.Models.User", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<int>("avatarId");

                    b.Property<int>("grade");

                    b.Property<string>("name");

                    b.Property<int>("points");

                    b.Property<string>("userName");

                    b.HasKey("UserId");

                    b.HasAnnotation("Relational:TableName", "Users");
                });

            modelBuilder.Entity("MeriEducation.Models.Question", b =>
                {
                    b.HasOne("MeriEducation.Models.Quiz")
                        .WithMany()
                        .HasForeignKey("quizId");
                });
        }
    }
}
