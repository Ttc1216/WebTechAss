CREATE TABLE [dbo].[Employment]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name] NCHAR(10) NOT NULL,
    [EmployerID] INT NOT NULL,
    [EmploymentCourseID] INT NOT NULL,
    [EmploymentTrainingID] INT NOT NULL,
    CONSTRAINT [FK_Employment_ToEmployer] FOREIGN KEY ([EmployerID]) REFERENCES [dbo].[Employer]([Id]),
    CONSTRAINT [FK_Employment_ToEmploymentCourse] FOREIGN KEY ([EmploymentCourseID]) REFERENCES [dbo].[EmploymentCourse]([Id]),
    CONSTRAINT [FK_Employment_ToEmploymentTraining] FOREIGN KEY ([EmploymentTrainingID]) REFERENCES [dbo].[EmploymentTraining]([Id])
);
