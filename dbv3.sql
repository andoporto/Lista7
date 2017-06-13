CREATE TABLE [dbo].[Estudiante](
	[EstudianteId] [int] IDENTITY(1,1) NOT NULL,
	[EstudianteNombre] [varchar](50) NOT NULL,
	[EstudianteGenero] [varchar](50) NOT NULL,
	 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
	 (
	[EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
 )