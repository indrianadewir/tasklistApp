

CREATE TABLE [dbo].[tasklists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tittle] [varchar](100) NOT NULL,
	[description] [varchar](500) NOT NULL,
	[status] [int] NOT NULL,
	[createdDate] [datetime] NOT NULL,
	[updateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tasklists] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[status](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StatusID] [int] NOT NULL,
	[Status] [varchar](100) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[status]
           ([StatusID]
           ,[Status])
     VALUES
           (1,'Pending'),
           (2,'In Progress'),
           (3,'Complete')
GO


