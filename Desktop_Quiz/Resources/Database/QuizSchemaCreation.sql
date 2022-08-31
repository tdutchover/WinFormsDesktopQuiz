-- TODO: Try these conditional commands
--DROP TABLE IF EXISTS dbo.QuestionAnswer
--DROP TABLE IF EXISTS dbo.Question
--DROP TABLE IF EXISTS dbo.Answer
--DROP TABLE IF EXISTS dbo.Score

--DROP TABLE dbo.QuestionAnswer
--DROP TABLE dbo.Question
--DROP TABLE dbo.Answer
--DROP TABLE dbo.Score

--GO
--CREATE TABLE dbo.Question(
--	QuestionId INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
--	[Description] nvarchar(MAX) NOT NULL
--);

-- GO
--CREATE TABLE dbo.Answer(
--	AnswerId INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
--	[Description] nvarchar(MAX) NOT NULL
--	);

-- GO
--CREATE TABLE dbo.QuestionAnswer(
--	QuestionId INT NOT NULL,
--	AnswerId INT NOT NULL,
--    [CorrectAnswer] BIT NOT NULL,
--	CONSTRAINT PK_QuestionAnswer PRIMARY KEY (QuestionId, AnswerId),
--	CONSTRAINT FK_QuestionAnswer_Question FOREIGN KEY (QuestionId) REFERENCES Question(QuestionId),
--	CONSTRAINT FK_QuestionAnswer_Answer FOREIGN KEY (AnswerId) REFERENCES Answer(AnswerId)
--	);

--GO
--CREATE TABLE dbo.Score(
--	ScoreId INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
--	[CallSign] nvarchar(50),
--	CorrectAnswerCount INT NOT NULL,
--);