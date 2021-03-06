USE [master]
GO
/****** Object:  Database [MeriEducation]    Script Date: 5/20/2016 8:37:35 AM ******/
CREATE DATABASE [MeriEducation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MeriEducation', FILENAME = N'C:\Users\veronica\MeriEducation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MeriEducation_log', FILENAME = N'C:\Users\veronica\MeriEducation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MeriEducation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MeriEducation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MeriEducation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MeriEducation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MeriEducation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MeriEducation] SET ARITHABORT OFF 
GO
ALTER DATABASE [MeriEducation] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MeriEducation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MeriEducation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MeriEducation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MeriEducation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MeriEducation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MeriEducation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MeriEducation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MeriEducation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MeriEducation] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MeriEducation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MeriEducation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MeriEducation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MeriEducation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MeriEducation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MeriEducation] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MeriEducation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MeriEducation] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MeriEducation] SET  MULTI_USER 
GO
ALTER DATABASE [MeriEducation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MeriEducation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MeriEducation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MeriEducation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MeriEducation] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MeriEducation]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_HistoryRow] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_IdentityRoleClaim<string>] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
 CONSTRAINT [PK_IdentityRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_IdentityUserClaim<string>] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_IdentityUserLogin<string>] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_IdentityUserRole<string>] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[AvatarId] [int] NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[HairId] [int] NULL,
	[LastName] [nvarchar](max) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[OutfitId] [int] NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[Points] [int] NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[SkinId] [int] NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[UserName] [nvarchar](256) NULL,
 CONSTRAINT [PK_ApplicationUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Avatars]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avatars](
	[AvatarId] [int] IDENTITY(1,1) NOT NULL,
	[HairId] [int] NOT NULL,
	[OutfitId] [int] NOT NULL,
	[SkinId] [int] NOT NULL,
 CONSTRAINT [PK_Avatar] PRIMARY KEY CLUSTERED 
(
	[AvatarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompletedQuestions]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompletedQuestions](
	[CompletedQuestionId] [int] IDENTITY(1,1) NOT NULL,
	[CompletedQuizId] [int] NOT NULL,
	[CorrectAnswer] [nvarchar](max) NULL,
	[QuestionAnswer] [nvarchar](max) NULL,
	[QuestionId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_CompletedQuestion] PRIMARY KEY CLUSTERED 
(
	[CompletedQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompletedQuizzes]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompletedQuizzes](
	[CompletedQuizId] [int] IDENTITY(1,1) NOT NULL,
	[InProgress] [bit] NOT NULL,
	[QuizId] [int] NOT NULL,
	[Score] [int] NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_CompletedQuiz] PRIMARY KEY CLUSTERED 
(
	[CompletedQuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hairs]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hairs](
	[HairId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Hair] PRIMARY KEY CLUSTERED 
(
	[HairId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Outfits]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Outfits](
	[OutfitId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Outfit] PRIMARY KEY CLUSTERED 
(
	[OutfitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Questions]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[Answer1] [nvarchar](max) NULL,
	[Answer2] [nvarchar](max) NULL,
	[Answer3] [nvarchar](max) NULL,
	[Answer4] [nvarchar](max) NULL,
	[CorrectAnswer] [nvarchar](max) NULL,
	[QuestionText] [nvarchar](max) NULL,
	[QuizId] [int] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quizzes]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quizzes](
	[QuizId] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Quiz] PRIMARY KEY CLUSTERED 
(
	[QuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Skins]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skins](
	[SkinId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Skin] PRIMARY KEY CLUSTERED 
(
	[SkinId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VocabWordLists]    Script Date: 5/20/2016 8:37:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VocabWordLists](
	[WordListId] [int] IDENTITY(1,1) NOT NULL,
	[Word1] [nvarchar](max) NULL,
	[Word2] [nvarchar](max) NULL,
	[Word3] [nvarchar](max) NULL,
	[Word4] [nvarchar](max) NULL,
 CONSTRAINT [PK_VocabWordList] PRIMARY KEY CLUSTERED 
(
	[WordListId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20160519202809_Initial', N'7.0.0-rc1-16348')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'1', NULL, N'Teacher', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'2', NULL, N'Student', NULL)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6e16dfa9-3424-4ac7-b067-ead2f347e9ad', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd5e51cf3-1847-4b6d-90cc-d4cc0f8a155d', N'1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ebc23f21-10dc-4bde-9925-196c11c98705', N'2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e', N'2')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [AvatarId], [ConcurrencyStamp], [Email], [EmailConfirmed], [FirstName], [HairId], [LastName], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [OutfitId], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [Points], [SecurityStamp], [SkinId], [TwoFactorEnabled], [UserName]) VALUES (N'6e16dfa9-3424-4ac7-b067-ead2f347e9ad', 0, NULL, N'b25bb9b5-89f4-4d2d-b562-9bbabca31824', NULL, 0, N'Alison', NULL, N'Vu', 1, NULL, NULL, N'STUDENT3@EMAIL.COM', NULL, N'AQAAAAEAACcQAAAAEHfvQ0k5Kk2BtmKkG0XMiJcSmzGI7aJC9cVsy/m+N0vhng27ZCgoWr515qdY8YYVbA==', NULL, 0, 13, N'efc90fbf-473c-43f4-bbad-20392fd22ade', NULL, 0, N'student3@email.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [AvatarId], [ConcurrencyStamp], [Email], [EmailConfirmed], [FirstName], [HairId], [LastName], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [OutfitId], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [Points], [SecurityStamp], [SkinId], [TwoFactorEnabled], [UserName]) VALUES (N'd5e51cf3-1847-4b6d-90cc-d4cc0f8a155d', 0, NULL, N'fc8098b0-7c58-4a87-8d46-7dbe55e0d35a', NULL, 0, N'Veronica', NULL, N'Alley', 1, NULL, NULL, N'TEACHER@EMAIL.COM', NULL, N'AQAAAAEAACcQAAAAEF6Feq+9NRlwhwH/DjM76oRaJcFllwUiGOQmCVzX6eZGAhmLJPlltE7I1yKIeN6NAA==', NULL, 0, NULL, N'96a08ce4-8347-4274-9120-3f8047de7389', NULL, 0, N'teacher@email.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [AvatarId], [ConcurrencyStamp], [Email], [EmailConfirmed], [FirstName], [HairId], [LastName], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [OutfitId], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [Points], [SecurityStamp], [SkinId], [TwoFactorEnabled], [UserName]) VALUES (N'ebc23f21-10dc-4bde-9925-196c11c98705', 0, 4, N'992ef13f-2e8d-4bb1-a583-8c03f8cea4ce', NULL, 0, N'Grace', 2, N'Kang', 1, NULL, NULL, N'STUDENT2@EMAIL.COM', 1, N'AQAAAAEAACcQAAAAELhsEyFw7d18go5WHHp8PSxNi3imOk1VtETxbZS/Tv/L3dP9WOblzR2Moq7DAlHpmQ==', NULL, 0, 0, N'bb869d60-b0c5-406b-a5c1-2551999297c7', 1, 0, N'student2@email.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [AvatarId], [ConcurrencyStamp], [Email], [EmailConfirmed], [FirstName], [HairId], [LastName], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [OutfitId], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [Points], [SecurityStamp], [SkinId], [TwoFactorEnabled], [UserName]) VALUES (N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e', 0, 3, N'033c670d-d9b1-4fd3-92b6-1a2d5cd2cebc', NULL, 0, N'Veronica', 2, N'Alley', 1, NULL, NULL, N'STUDENT@EMAIL.COM', 2, N'AQAAAAEAACcQAAAAEADAW0hBZfBLwibvtRQr3VBJWRhynBZToKppn5CKMlUIsTmGNOABuaPG/bk8K08xbQ==', NULL, 0, 30, N'f1eafe40-f396-4a65-a798-30398c736b61', 1, 0, N'student@email.com')
SET IDENTITY_INSERT [dbo].[Avatars] ON 

INSERT [dbo].[Avatars] ([AvatarId], [HairId], [OutfitId], [SkinId]) VALUES (3, 2, 2, 1)
INSERT [dbo].[Avatars] ([AvatarId], [HairId], [OutfitId], [SkinId]) VALUES (4, 2, 1, 1)
SET IDENTITY_INSERT [dbo].[Avatars] OFF
SET IDENTITY_INSERT [dbo].[CompletedQuestions] ON 

INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (1, 1, N'Answer1', N'Answer1', 6, N'ebc23f21-10dc-4bde-9925-196c11c98705')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (2, 1, N'D', N'Answer2', 7, N'ebc23f21-10dc-4bde-9925-196c11c98705')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (3, 2, N'Answer3', N'Answer3', 2, N'ebc23f21-10dc-4bde-9925-196c11c98705')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (5, 5, N'Answer1', N'Answer1', 6, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (6, 7, N'Answer1', N'Answer1', 6, N'6e16dfa9-3424-4ac7-b067-ead2f347e9ad')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (7, 7, N'D', N'Answer4', 7, N'6e16dfa9-3424-4ac7-b067-ead2f347e9ad')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (8, 7, N'Answer1', N'Answer4', 6, N'6e16dfa9-3424-4ac7-b067-ead2f347e9ad')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (10, 10, N'Answer1', N'Answer1', 9, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (11, 10, N'Answer1', N'Answer1', 10, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (12, 10, N'Answer1', N'Answer1', 11, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (13, 5, N'Answer1', N'Answer1', 6, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuestions] ([CompletedQuestionId], [CompletedQuizId], [CorrectAnswer], [QuestionAnswer], [QuestionId], [UserId]) VALUES (14, 5, N'Answer4', N'Answer4', 7, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
SET IDENTITY_INSERT [dbo].[CompletedQuestions] OFF
SET IDENTITY_INSERT [dbo].[CompletedQuizzes] ON 

INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (1, 0, 3, 50, N'ebc23f21-10dc-4bde-9925-196c11c98705')
INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (2, 1, 2, NULL, N'ebc23f21-10dc-4bde-9925-196c11c98705')
INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (5, 0, 3, 100, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (6, 1, 2, NULL, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (7, 0, 3, 33, N'6e16dfa9-3424-4ac7-b067-ead2f347e9ad')
INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (8, 1, 2, NULL, N'6e16dfa9-3424-4ac7-b067-ead2f347e9ad')
INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (10, 0, 5, 100, N'ed5830c4-3b68-4bec-a7f7-b7d5af37363e')
INSERT [dbo].[CompletedQuizzes] ([CompletedQuizId], [InProgress], [QuizId], [Score], [UserId]) VALUES (11, 1, 5, NULL, N'ebc23f21-10dc-4bde-9925-196c11c98705')
SET IDENTITY_INSERT [dbo].[CompletedQuizzes] OFF
SET IDENTITY_INSERT [dbo].[Hairs] ON 

INSERT [dbo].[Hairs] ([HairId], [Name], [Price]) VALUES (1, N'Braids', 5)
INSERT [dbo].[Hairs] ([HairId], [Name], [Price]) VALUES (2, N'The Mollie', 5)
INSERT [dbo].[Hairs] ([HairId], [Name], [Price]) VALUES (3, N'Waves', 5)
SET IDENTITY_INSERT [dbo].[Hairs] OFF
SET IDENTITY_INSERT [dbo].[Outfits] ON 

INSERT [dbo].[Outfits] ([OutfitId], [Name], [Price]) VALUES (1, N'Space pants', 50)
INSERT [dbo].[Outfits] ([OutfitId], [Name], [Price]) VALUES (2, N'Black dress', 50)
SET IDENTITY_INSERT [dbo].[Outfits] OFF
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (2, N'Benjamin Franklin', N'Thomas Jefferson', N'Barack Obama', N'George Washington', N'Answer3', N'Who was NOT one of the founding fathers?', 2)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (3, N'45th', N'1st', N'3rd', N'16th', N'Answer4', N'Abraham Lincoln was the  __ president.', 2)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (4, N'Italian', N'German', N'English', N'Russian', N'Answer1', N'Marco Polo was _____.', 2)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (5, N'respect the rights of others', N'vote for leaders', N'help make the community a better place', N'all of the above', N'Answer4', N'Examples of responsibilities of citizens include:', 2)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (6, N'not', N'in', N'before', N'wrong', N'Answer1', N'In the word "unlucky" the prefix un- means what?', 3)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (7, N'Roger is my best friend.', N'Roger is my neighbor.', N'Roger and his family are nice to me.', N'Roger and I play games on the computer.', N'Answer4', N'Which sentence contains an action verb?', 3)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (9, N'pH', N'temperature', N'volume', N'turbidity', N'Answer1', N'Type of aquatic animals that can survive in particular water is determined by analyzing its', 5)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (10, N'symbiosis', N'mutualism', N'parasitism', N'food chain', N'Answer1', N'Mutual relationship between two organism both benefiting each other is called', 5)
INSERT [dbo].[Questions] ([QuestionId], [Answer1], [Answer2], [Answer3], [Answer4], [CorrectAnswer], [QuestionText], [QuizId]) VALUES (11, N'lichens', N'leeches', N'ticks', N'hyphae', N'Answer1', N'Algae and fungus living together form', 5)
SET IDENTITY_INSERT [dbo].[Questions] OFF
SET IDENTITY_INSERT [dbo].[Quizzes] ON 

INSERT [dbo].[Quizzes] ([QuizId], [Grade], [Name]) VALUES (2, 1, N'Social Studies')
INSERT [dbo].[Quizzes] ([QuizId], [Grade], [Name]) VALUES (3, 3, N'Language Arts')
INSERT [dbo].[Quizzes] ([QuizId], [Grade], [Name]) VALUES (5, 9, N'Science')
SET IDENTITY_INSERT [dbo].[Quizzes] OFF
SET IDENTITY_INSERT [dbo].[Skins] ON 

INSERT [dbo].[Skins] ([SkinId], [Name]) VALUES (1, N'Medium-Dark')
SET IDENTITY_INSERT [dbo].[Skins] OFF
SET IDENTITY_INSERT [dbo].[VocabWordLists] ON 

INSERT [dbo].[VocabWordLists] ([WordListId], [Word1], [Word2], [Word3], [Word4]) VALUES (1, N'didactic', N'extraneous', N'superb', N'conflagration')
INSERT [dbo].[VocabWordLists] ([WordListId], [Word1], [Word2], [Word3], [Word4]) VALUES (2, N'bungle', N'exploit', N'disingenous', N'chaos')
INSERT [dbo].[VocabWordLists] ([WordListId], [Word1], [Word2], [Word3], [Word4]) VALUES (3, N'exploit', N'chaos', N'numeral', N'pedantic')
SET IDENTITY_INSERT [dbo].[VocabWordLists] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/20/2016 8:37:35 AM ******/
CREATE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 5/20/2016 8:37:35 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/20/2016 8:37:35 AM ******/
CREATE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_IdentityRoleClaim<string>_IdentityRole_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_IdentityRoleClaim<string>_IdentityRole_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_IdentityUserClaim<string>_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_IdentityUserClaim<string>_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_IdentityUserLogin<string>_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_IdentityUserLogin<string>_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_IdentityUserRole<string>_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_IdentityUserRole<string>_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_IdentityUserRole<string>_IdentityRole_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_IdentityUserRole<string>_IdentityRole_RoleId]
GO
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUser_Avatar_AvatarId] FOREIGN KEY([AvatarId])
REFERENCES [dbo].[Avatars] ([AvatarId])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_ApplicationUser_Avatar_AvatarId]
GO
ALTER TABLE [dbo].[Avatars]  WITH CHECK ADD  CONSTRAINT [FK_Avatar_Hair_HairId] FOREIGN KEY([HairId])
REFERENCES [dbo].[Hairs] ([HairId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Avatars] CHECK CONSTRAINT [FK_Avatar_Hair_HairId]
GO
ALTER TABLE [dbo].[Avatars]  WITH CHECK ADD  CONSTRAINT [FK_Avatar_Outfit_OutfitId] FOREIGN KEY([OutfitId])
REFERENCES [dbo].[Outfits] ([OutfitId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Avatars] CHECK CONSTRAINT [FK_Avatar_Outfit_OutfitId]
GO
ALTER TABLE [dbo].[Avatars]  WITH CHECK ADD  CONSTRAINT [FK_Avatar_Skin_SkinId] FOREIGN KEY([SkinId])
REFERENCES [dbo].[Skins] ([SkinId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Avatars] CHECK CONSTRAINT [FK_Avatar_Skin_SkinId]
GO
ALTER TABLE [dbo].[CompletedQuestions]  WITH CHECK ADD  CONSTRAINT [FK_CompletedQuestion_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[CompletedQuestions] CHECK CONSTRAINT [FK_CompletedQuestion_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[CompletedQuestions]  WITH CHECK ADD  CONSTRAINT [FK_CompletedQuestion_CompletedQuiz_CompletedQuizId] FOREIGN KEY([CompletedQuizId])
REFERENCES [dbo].[CompletedQuizzes] ([CompletedQuizId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CompletedQuestions] CHECK CONSTRAINT [FK_CompletedQuestion_CompletedQuiz_CompletedQuizId]
GO
ALTER TABLE [dbo].[CompletedQuestions]  WITH CHECK ADD  CONSTRAINT [FK_CompletedQuestion_Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Questions] ([QuestionId])
GO
ALTER TABLE [dbo].[CompletedQuestions] CHECK CONSTRAINT [FK_CompletedQuestion_Question_QuestionId]
GO
ALTER TABLE [dbo].[CompletedQuizzes]  WITH CHECK ADD  CONSTRAINT [FK_CompletedQuiz_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[CompletedQuizzes] CHECK CONSTRAINT [FK_CompletedQuiz_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[CompletedQuizzes]  WITH CHECK ADD  CONSTRAINT [FK_CompletedQuiz_Quiz_QuizId] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quizzes] ([QuizId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CompletedQuizzes] CHECK CONSTRAINT [FK_CompletedQuiz_Quiz_QuizId]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Question_Quiz_QuizId] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quizzes] ([QuizId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Question_Quiz_QuizId]
GO
USE [master]
GO
ALTER DATABASE [MeriEducation] SET  READ_WRITE 
GO
