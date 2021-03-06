using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MeriEducation.Models;

namespace MeriEducation.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160519202809_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeriEducation.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("AvatarId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int?>("HairId");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<int?>("OutfitId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int?>("Points");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("SkinId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("MeriEducation.Models.Avatar", b =>
                {
                    b.Property<int>("AvatarId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HairId");

                    b.Property<int>("OutfitId");

                    b.Property<int>("SkinId");

                    b.HasKey("AvatarId");

                    b.HasAnnotation("Relational:TableName", "Avatars");
                });

            modelBuilder.Entity("MeriEducation.Models.CompletedQuestion", b =>
                {
                    b.Property<int>("CompletedQuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompletedQuizId");

                    b.Property<string>("CorrectAnswer");

                    b.Property<string>("QuestionAnswer");

                    b.Property<int>("QuestionId");

                    b.Property<string>("UserId");

                    b.HasKey("CompletedQuestionId");

                    b.HasAnnotation("Relational:TableName", "CompletedQuestions");
                });

            modelBuilder.Entity("MeriEducation.Models.CompletedQuiz", b =>
                {
                    b.Property<int>("CompletedQuizId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("InProgress");

                    b.Property<int>("QuizId");

                    b.Property<int?>("Score");

                    b.Property<string>("UserId");

                    b.HasKey("CompletedQuizId");

                    b.HasAnnotation("Relational:TableName", "CompletedQuizzes");
                });

            modelBuilder.Entity("MeriEducation.Models.Hair", b =>
                {
                    b.Property<int>("HairId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("HairId");

                    b.HasAnnotation("Relational:TableName", "Hairs");
                });

            modelBuilder.Entity("MeriEducation.Models.Outfit", b =>
                {
                    b.Property<int>("OutfitId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("OutfitId");

                    b.HasAnnotation("Relational:TableName", "Outfits");
                });

            modelBuilder.Entity("MeriEducation.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer1");

                    b.Property<string>("Answer2");

                    b.Property<string>("Answer3");

                    b.Property<string>("Answer4");

                    b.Property<string>("CorrectAnswer");

                    b.Property<string>("QuestionText");

                    b.Property<int>("QuizId");

                    b.HasKey("QuestionId");

                    b.HasAnnotation("Relational:TableName", "Questions");
                });

            modelBuilder.Entity("MeriEducation.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Grade");

                    b.Property<string>("Name");

                    b.HasKey("QuizId");

                    b.HasAnnotation("Relational:TableName", "Quizzes");
                });

            modelBuilder.Entity("MeriEducation.Models.Skin", b =>
                {
                    b.Property<int>("SkinId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("SkinId");

                    b.HasAnnotation("Relational:TableName", "Skins");
                });

            modelBuilder.Entity("MeriEducation.Models.VocabWordList", b =>
                {
                    b.Property<int>("WordListId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Word1");

                    b.Property<string>("Word2");

                    b.Property<string>("Word3");

                    b.Property<string>("Word4");

                    b.HasKey("WordListId");

                    b.HasAnnotation("Relational:TableName", "VocabWordLists");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("MeriEducation.Models.ApplicationUser", b =>
                {
                    b.HasOne("MeriEducation.Models.Avatar")
                        .WithOne()
                        .HasForeignKey("MeriEducation.Models.ApplicationUser", "AvatarId");
                });

            modelBuilder.Entity("MeriEducation.Models.Avatar", b =>
                {
                    b.HasOne("MeriEducation.Models.Hair")
                        .WithMany()
                        .HasForeignKey("HairId");

                    b.HasOne("MeriEducation.Models.Outfit")
                        .WithMany()
                        .HasForeignKey("OutfitId");

                    b.HasOne("MeriEducation.Models.Skin")
                        .WithMany()
                        .HasForeignKey("SkinId");
                });

            modelBuilder.Entity("MeriEducation.Models.CompletedQuestion", b =>
                {
                    b.HasOne("MeriEducation.Models.CompletedQuiz")
                        .WithMany()
                        .HasForeignKey("CompletedQuizId");

                    b.HasOne("MeriEducation.Models.Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");

                    b.HasOne("MeriEducation.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MeriEducation.Models.CompletedQuiz", b =>
                {
                    b.HasOne("MeriEducation.Models.Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");

                    b.HasOne("MeriEducation.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MeriEducation.Models.Question", b =>
                {
                    b.HasOne("MeriEducation.Models.Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MeriEducation.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MeriEducation.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("MeriEducation.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
