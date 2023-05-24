CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [EmployerID] NCHAR(10) NOT NULL, 
    [EmploymentCourseID] NCHAR(10) NOT NULL, 
    [EmploymentTrainingID] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Employee_ToEmployer] FOREIGN KEY ([EmployerID]) REFERENCES [Employer]([ID]), 
    CONSTRAINT [FK_Employee_ToEmploymentCourse] FOREIGN KEY ([EmploymentCourseID]) REFERENCES [EmploymentCourse]([ID]), 
    CONSTRAINT [FK_Employee_ToEmploymentTraining] FOREIGN KEY ([EmploymentTrainingID]) REFERENCES [EmployementTraining]([ID])
)
