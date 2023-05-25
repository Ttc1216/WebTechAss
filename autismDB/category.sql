CREATE TABLE [dbo].[category] (
  [id] BIGINT IDENTITY(1,1) NOT NULL,
  [parentId] BIGINT NULL,
  [title] VARCHAR(75) NOT NULL,
  [metaTitle] VARCHAR(100) NULL,
  [slug] VARCHAR(100) NOT NULL,
  [content] TEXT NULL,
  PRIMARY KEY ([id])
)
GO

CREATE INDEX [idx_category_parent] ON [dbo].[category] ([parentId] ASC)
GO

ALTER TABLE [dbo].[category] 
ADD CONSTRAINT [fk_category_parent]
  FOREIGN KEY ([parentId])
  REFERENCES [dbo].[category] ([id])
  ON DELETE NO ACTION
  ON UPDATE NO ACTION
GO
