DROP TABLE dbo.Question
CREATE TABLE dbo.Question(
	question_id INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
	[description] nvarchar(MAX) NOT NULL)