CREATE TABLE [dbo].[post] (
  [id] BIGINT IDENTITY(1,1) NOT NULL,
  [authorId] BIGINT NOT NULL,
  [parentId] BIGINT NULL,
  [title] VARCHAR(75) NOT NULL,
  [metaTitle] VARCHAR(100) NULL,
  [slug] VARCHAR(100) NOT NULL,
  [summary] NVARCHAR(MAX) NULL,
  [published] BIT NOT NULL DEFAULT 0,
  [createdAt] DATETIME NOT NULL,
  [updatedAt] DATETIME NULL,
  [publishedAt] DATETIME NULL,
  [content] NVARCHAR(MAX) NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [uq_slug] UNIQUE ([slug] ASC),
  INDEX [idx_post_user] ([authorId] ASC),
  CONSTRAINT [fk_post_user]
    FOREIGN KEY ([authorId])
    REFERENCES [dbo].[user] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
GO

CREATE INDEX [idx_post_parent] ON [dbo].[post] ([parentId] ASC);
GO

ALTER TABLE [dbo].[post] 
ADD CONSTRAINT [fk_post_parent]
  FOREIGN KEY ([parentId])
  REFERENCES [dbo].[post] ([id])
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
GO
