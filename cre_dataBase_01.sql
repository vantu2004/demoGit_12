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

		  Fname NVARCHAR(62)  NOT NULL,         -- Tên NTD
		 Gender NVARCHAR(10),			        -- Giới tính
	   PhoneNTD NVARCHAR(12)  NOT NULL,         -- Số ĐT của NTD
	     JobPos NVARCHAR(62)  NOT NULL,         -- Vị trí công tác
		Company	NVARCHAR(62)  NOT NULL,         -- Công Ty
	JobLocation NVARCHAR(100) NOT NULL,         -- Địa điểm làm việc
   ContactEmail NVARCHAR(100) NOT NULL,         -- Mạng xã hội

	FOREIGN KEY (Id,UserType) REFERENCES PASSWORDS(UserID,UserType)
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
	Applied_pos NVARCHAR(20),

	FOREIGN KEY (Id,UserType) REFERENCES PASSWORDS(UserID,UserType)
);
GO