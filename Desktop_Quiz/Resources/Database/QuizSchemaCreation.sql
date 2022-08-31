-- TODO: Try these conditional commands
--DROP TABLE IF EXISTS dbo.QuestionAnswer
--DROP TABLE IF EXISTS dbo.Question
--DROP TABLE IF EXISTS dbo.Answer

--DROP TABLE dbo.QuestionAnswer
--DROP TABLE dbo.Question
--DROP TABLE dbo.Answer

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
