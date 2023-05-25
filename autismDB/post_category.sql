CREATE TABLE [dbo].[post_category]
(
  [postId] BIGINT NOT NULL,
  [categoryId] BIGINT NOT NULL,
  PRIMARY KEY ([postId], [categoryId]),
  INDEX [idx_pc_category] ([categoryId] ASC),
  INDEX [idx_pc_post] ([postId] ASC),
  CONSTRAINT [fk_pc_post]
    FOREIGN KEY ([postId])
    REFERENCES [dbo].[post] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_pc_category]
    FOREIGN KEY ([categoryId])
    REFERENCES [dbo].[category] ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
