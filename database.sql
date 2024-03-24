CREATE DATABASE WIPR
GO

USE WIPR
GO

CREATE TABLE [dbo].[TAIKHOAN] (
    [Id]           VARCHAR (50) NOT NULL,
    [UserType]     VARCHAR (50) NOT NULL,

    [UserName]     VARCHAR (32) NOT NULL,
    [UserPassword] VARCHAR (32) NOT NULL,

    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([UserName] ASC)
);
GO

-- Nhà tuyển dụng
CREATE TABLE [dbo].[NHATUYENDUNG] (
    [Id]            VARCHAR (50)   NOT NULL,
    [UserType]      VARCHAR (50)   NOT NULL,

    [Fname]         NVARCHAR (62)  NOT NULL,
    [Email]         NVARCHAR (62)  NOT NULL,
    [PhoneNTD]      NVARCHAR (12)  NOT NULL,
    [JobPos]        NVARCHAR (62)  NOT NULL,
    [Company]       NVARCHAR (62)  NOT NULL,
    [JobLocation]   NVARCHAR (100) NOT NULL,
    [SocialNetwork] NVARCHAR (100) NOT NULL,

    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[TAIKHOAN] ([Id])
);
GO

-- Ứng viên
CREATE TABLE [dbo].[UNGVIEN] (
    [Id]        VARCHAR (50)   NOT NULL,
    [UserType]  VARCHAR (50)   NOT NULL,

    [Fname]     NVARCHAR (100) NOT NULL,
    [Phone]     VARCHAR (12)   NOT NULL,
    [BirthDate] VARCHAR (50)   NOT NULL,
    [Link]      VARCHAR (100)  NOT NULL,
    [Email]     NVARCHAR (62)  NOT NULL,
    [Address_C] NVARCHAR (100) NOT NULL,
    [Gender]    NVARCHAR (10)  NOT NULL,

    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[TAIKHOAN] ([Id])
);
GO

--Tin tuyển dụng
CREATE TABLE [dbo].[JobPostings] (
	[Id]		     VARCHAR (50)   NOT NULL,
	[UserType]       VARCHAR (50)	NOT NULL,

    [IconCompany]    IMAGE			NOT NULL,
	[Company]        NVARCHAR (62)  NOT NULL,
	[SocialNetwork]  NVARCHAR (100) NOT NULL,
	[JobLocation]    NVARCHAR (100) NOT NULL,
	[Job]			 NVARCHAR (30)	NOT NULL,
	[PositionNeeded] NVARCHAR (62)  NOT NULL,
	[Salary]		 DECIMAL(10, 2) NOT NULL,
	[Experience]	 NVARCHAR (100) NOT NULL,
	[WorkFormat]	 NVARCHAR (100) NOT NULL,
	[Fname]			 NVARCHAR (100)	NOT NULL,
	[Email]          NVARCHAR (62)	NOT NULL,
	[PhoneNTD]       NVARCHAR (12)	NOT NULL,
	[JobPos]         NVARCHAR (62)	NOT NULL,
	[DatePosted]	 VARCHAR (50)	NOT NULL,
	[Deadline]		 VARCHAR (50)	NOT NULL,

	[JobDescription] TEXT			NOT NULL,
	[Requirements]   TEXT			NOT NULL,
	[Benefit]		 TEXT			NOT NULL,

	PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Id]) REFERENCES [dbo].[NHATUYENDUNG] ([Id])
);
GO

--Đơn ứng tuyển
CREATE TABLE Applications (
    JobID INT,
    CandidateID INT,	   -- Mã ứng viên
    ApplicationDate DATE,  -- Ngày ứng tuyển
    AStatus VARCHAR(50),   -- Trạng thái (đậu hay chưa đậu )

	FOREIGN KEY (JobID) REFERENCES JobPostings(JobID),
    FOREIGN KEY (CandidateID) REFERENCES UNGVIEN(Id),

	PRIMARY KEY(jobID, CandidateID),
);
GO

--Bảng các CV
CREATE TABLE CVs (
    CandidateID INT PRIMARY KEY,

	--Avatar, Fname, BirthDate, Gender, Phone, Link, Email, Address_C, Gender 
	-- lấy từ UNGVIEN INNER JOIN CVs

	JobPos NVARCHAR(62) NOT NULL, -- Vị trí ứng tuyển
	
	CareerGoal	TEXT, -- Mục tiêu nghề nghiệp
	Education   TEXT, -- Học vấn
	Experience	TEXT, -- Kinh nghiệm

    UploadDate  DATE, --Ngày cập nhật

    FOREIGN KEY (CandidateID) REFERENCES UNGVIEN(Id)
);
GO
