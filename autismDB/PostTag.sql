CREATE TABLE [dbo].[PostTag]
(
  [PostId] BIGINT NOT NULL,
  [TagId] BIGINT NOT NULL,
  PRIMARY KEY ([PostId], [TagId]),
  CONSTRAINT [FK_PostTag_Post]
    FOREIGN KEY ([PostId])
    REFERENCES [dbo].[Post] ([Id])
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT [FK_PostTag_Tag]
    FOREIGN KEY ([TagId])
    REFERENCES [dbo].[Tag] ([Id])
    ON DELETE CASCADE
    ON UPDATE CASCADE
);
