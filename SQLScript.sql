CREATE TABLE [dbo].[Users] (
    [Username] CHAR (30) NOT NULL,
    [DOB]      DATE      NULL,
    [Wins]     INT       NULL,
    [Draws]    INT       NULL,
    [Loss]     INT       NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);