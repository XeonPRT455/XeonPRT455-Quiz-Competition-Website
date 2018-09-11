USE [master]
GO
 
IF EXISTS(SELECT 1 FROM sysdatabases WHERE NAME=N'QuizCompetition')
BEGIN
    DROP DATABASE QuizCompetition  
END
GO
 
CREATE DATABASE QuizCompetition
ON
PRIMARY  
(
    NAME='QuizCompetition',
    FILENAME='E:\Databases\QuizCompetition.dbf',
    SIZE=5MB,
    MaxSize=20MB,
    FileGrowth=1MB
)
LOG ON 
(
    NAME='QuizCompetitionLog',
    FileName='E:\Databases\QuizCompetition.ldf',
    Size=2MB,
    MaxSize=20MB,
    FileGrowth=1MB
)
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_role'))
BEGIN
CREATE TABLE t_role
(
    RoleId INT IDENTITY(1,1) NOT NULL,
    RoleName NVARCHAR(20) NOT NULL,
    
	CONSTRAINT [PK_ROLE] PRIMARY KEY CLUSTERED ([RoleId] ASC),
   
) 
END
GO


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_user') AND type in (N'U'))
BEGIN
CREATE TABLE t_user
(
    UserId INT IDENTITY(1,1) NOT NULL,
	UserName NVARCHAR(20) NOT NULL,
    NickName NVARCHAR(20),
	UserRole NVARCHAR(20) NOT NULL,
    PassWord NVARCHAR(30) NOT NULL,
    CreateDate DATETIME,
    Email NVARCHAR(50),
    Phone NVARCHAR(50),
    Sex INT,
	Birth DATETIME,
    LastTimeLogOn DATETIME,
	Credits Float
	
  
    CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED ([UserId] ASC),
	CONSTRAINT [UK_USER_NICKNAME] UNIQUE NONCLUSTERED ([NickName] ASC),

  

   
) 
END
GO



IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_question'))
BEGIN
CREATE TABLE t_question
(
    QuestionId INT IDENTITY(1,1) NOT NULL,
    Question NVARCHAR(256) NOT NULL,
    CreatorId INT NOT NULL,
	Answer  NVARCHAR(20) NOT NULL,

	CONSTRAINT [PK_QUESTION] PRIMARY KEY CLUSTERED ([QuestionId] ASC),
	CONSTRAINT [FK_QUESTION_USER_CREATORID] FOREIGN KEY ([CreatorId]) REFERENCES [t_user] (UserId)

   
) 
END
GO





IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_options'))
BEGIN
CREATE TABLE t_options
(
    QuestionId INT  NOT NULL,
	OptionId INT NOT NULL,
    OptionContent NVARCHAR(256) NOT NULL,
    
	CONSTRAINT [PK_OPTIONS] PRIMARY KEY CLUSTERED ([QuestionId] ASC),

	CONSTRAINT [FK_QUESTION_OPTIONS_QUESTIONID] FOREIGN KEY ([QuestionId]) REFERENCES [t_question] (QuestionId)

   
) 
END
GO


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_quiz'))
BEGIN
CREATE TABLE t_quiz
(
    QuizId INT IDENTITY(1,1) NOT NULL,
    QuizName NVARCHAR(20) NOT NULL,
    CreatorId INT NOT NULL,
	CreateDate DATETIME,
	Duration INT,

	CONSTRAINT [PK_QUIZ] PRIMARY KEY CLUSTERED ([QuizId] ASC),
	CONSTRAINT [FK_QUIZ_USER_CREATORID] FOREIGN KEY ([CreatorId]) REFERENCES [t_user] (UserId)

   
) 
END
GO



IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_Question_Quiz'))
BEGIN
CREATE TABLE t_Question_Quiz
(
    QuizId INT NOT NULL,
    QuestionId INT  NOT NULL,
  
    
	CONSTRAINT [PK_QQ] PRIMARY KEY CLUSTERED ([QuizId] ASC),

	CONSTRAINT [FK_QUESTION_QQ1] FOREIGN KEY ([QuestionId]) REFERENCES [t_question] (QuestionId),
	CONSTRAINT [FK_QUESTION_QQ2] FOREIGN KEY ([QuizId]) REFERENCES [t_quiz] (QuizId)
   
) 
END
GO


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_QuizInfo'))
BEGIN
CREATE TABLE t_QuizInfo
(
    QuizId INT NOT NULL,
    UserId INT  NOT NULL,
	Record NVARCHAR(256) NOT NULL,
	StartTime DATETIME NOT NULL,
	EndTime DATETIME NOT NULL,
	SpareTime Float,
  
    
	CONSTRAINT [PK_QI] PRIMARY KEY CLUSTERED ([UserId] ASC),

	CONSTRAINT [FK_QI1] FOREIGN KEY ([UserId]) REFERENCES [t_user] (UserId),
	CONSTRAINT [FK_QI2] FOREIGN KEY ([QuizId]) REFERENCES [t_quiz] (QuizId)
   
) 
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N't_ScoreInfo'))
BEGIN
CREATE TABLE t_ScoreInfo
(
    
    UserId INT  NOT NULL,
	QuizId INT NOT NULL,
	Score INT NOT NULL,
  
    
	CONSTRAINT [PK_QI] PRIMARY KEY CLUSTERED ([UserId] ASC),

	CONSTRAINT [FK_QI1] FOREIGN KEY ([UserId]) REFERENCES [t_user] (UserId),
	CONSTRAINT [FK_QI2] FOREIGN KEY ([QuizId]) REFERENCES [t_quiz] (QuizId)
   
) 
END
GO