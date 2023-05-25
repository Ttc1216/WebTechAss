CREATE TABLE [dbo].[post_comment] (
  [id] BIGINT IDENTITY(1,1) NOT NULL,
  [postId] BIGINT NOT NULL,
  [parentId] BIGINT NULL,
  [title] VARCHAR(100) NOT NULL,
  [published] BIT NOT NULL DEFAULT 0,
  [createdAt] DATETIME NOT NULL,
  [publishedAt] DATETIME NULL,
  [content] TEXT NULL,
  PRIMARY KEY ([id]),
  INDEX [idx_comment_post] ([postId] ASC),
  CONSTRAINT [fk_comment_post]
    FOREIGN KEY ([postId])
    REFERENCES [dbo].[post] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
GO

CREATE INDEX [idx_comment_parent] ON [dbo].[post_comment] ([parentId] ASC);
GO

ALTER TABLE [dbo].[post_comment] 
ADD CONSTRAINT [fk_comment_parent]
  FOREIGN KEY ([parentId])
  REFERENCES [dbo].[post_comment] ([id])
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
GO
