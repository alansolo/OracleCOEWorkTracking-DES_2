CREATE TABLE [dbo].[ApplicationAttribute](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[DeleteMark] [bit] NOT NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[ApplicationId] [int] NULL,
	[Attribute1] [nvarchar](50) NULL,
	[Attribute2] [nvarchar](50) NULL,
	[Attribute3] [nvarchar](50) NULL,
	[Attribute4] [nvarchar](50) NULL,
	[Attribute5] [nvarchar](50) NULL,
	[Attribute6] [nvarchar](50) NULL,
	[Attribute7] [nvarchar](50) NULL,
	[Attribute8] [nvarchar](50) NULL,
	[Attribute9] [nvarchar](50) NULL,
	[Attribute10] [nvarchar](50) NULL,
 CONSTRAINT [PK_ApplicationAttribute] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ApplicationAttribute]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationAttribute_Applications] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[Applications] ([Id])
GO

ALTER TABLE [dbo].[ApplicationAttribute] CHECK CONSTRAINT [FK_ApplicationAttribute_Applications]
GO