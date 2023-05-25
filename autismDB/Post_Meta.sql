CREATE TABLE [dbo].[Post_Meta]
 (
  [id] BIGINT IDENTITY(1,1) NOT NULL,
  [postId] BIGINT NOT NULL,
  [key] VARCHAR(50) NOT NULL,
  [content] TEXT NULL,
  PRIMARY KEY ([id]),
  INDEX [idx_meta_post] ([postId] ASC),
  CONSTRAINT [uq_post_meta] UNIQUE ([postId] ASC, [key] ASC),
  CONSTRAINT [fk_meta_post]
    FOREIGN KEY ([postId])
    REFERENCES [dbo].[post] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
