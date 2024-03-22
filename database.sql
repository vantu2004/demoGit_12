CREATE DATABASE WIPR
GO

USE WIPR
GO

CREATE TABLE TAIKHOAN(
	     UserID INT,
	   UserType VARCHAR(12), 

	   UserName VARCHAR(32) UNIQUE	 ,
   UserPassword VARCHAR(32) NOT NULL,
 
   PRIMARY KEY(UserID, UserType)
)
GO

-- Nhà tuyển dụng
CREATE TABLE NHATUYENDUNG(
			 Id INT IDENTITY(1,1) PRIMARY KEY,
	   UserType VARCHAR(12) DEFAULT 'Employer', -- Mặc định

  --IconCompany IMAGE		  NULL,             -- Biểu tượng Công ty
		  Fname NVARCHAR(62)  NOT NULL,         -- Tên NTD
		 Email  NVARCHAR(62)  NOT NULL,			-- Email NTD
	   PhoneNTD NVARCHAR(12)  NOT NULL,         -- Số ĐT của NTD
	     JobPos NVARCHAR(62)  NOT NULL,         -- Vị trí công tác
		Company	NVARCHAR(62)  NOT NULL,         -- Công Ty
	JobLocation NVARCHAR(100) NOT NULL,         -- Địa điểm làm việc
   ContactEmail NVARCHAR(100) NOT NULL,         -- Mạng xã hội

	FOREIGN KEY (Id,UserType) REFERENCES TAIKHOAN(UserID,UserType)
);
GO

-- Ứng viên
CREATE TABLE UNGVIEN(
		     Id INT IDENTITY(1,1) PRIMARY KEY,
	   UserType VARCHAR(12) DEFAULT 'Candidate',

	   --Avatar IMAGE NULL,                     -- Ảnh của ungvien
	      Fname NVARCHAR(62)  NOT NULL,
	      Phone VARCHAR (12)  NOT NULL,
	  BirthDate DATE ,
	       Link VARCHAR (100) NOT NULL,	
	      Email NVARCHAR(62)  NOT NULL, 
	  Address_C NVARCHAR(100) NOT NULL,         -- dia diem hien tai
	     Gender NVARCHAR(10),

	FOREIGN KEY (Id,UserType) REFERENCES TAIKHOAN(UserID,UserType)
);
GO

--Tin tuyển dụng
CREATE TABLE JobPostings (
	JobID INT IDENTITY PRIMARY KEY,
	EmpID INT,    -- Mã người đăng

	-- IconCompany, Company, ContactEmail, PhoneNTD lấy từ NHATUYENDUNG

	 JobLocation VARCHAR(100),   -- Nơi làm việc
		  Career NVARCHAR(100),	 -- Nghề nghiệp
	      Salary DECIMAL(10, 2), -- Sử dụng DECIMAL cho mức lương để đảm bảo chính xác.
	  Experience NVARCHAR(100),  -- Kinh nghiệm
	  WorkFormat NVARCHAR(100),  -- Hình thức làm việc

	JobDescription TEXT, --Mô tả công việc
	  Requirements TEXT, --Yêu cầu
		  Benefit  TEXT, --Quyền lợi

--Bổ sung
	DatePosted DATE, -- Ngày đăng
      Deadline DATE, -- Hạn chót
    
	CONSTRAINT WorkFormat CHECK (WorkFormat IN ('Office', 'flexible')), 
    FOREIGN KEY (EmpID) REFERENCES NHATUYENDUNG(Id)
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
