USE [C:\USERS\MR MOBILE\DOCUMENTS\SCHOOLMANAGE.MDF]
CREATE TABLE Users
(  FullName NVARCHAR(80),
   Password NVARCHAR(50),
   UserName NVARCHAR(50)
   );

   INSERT INTO Users (FullName, Password, UserName) VALUES
   ('محمد احمدی','mohamad123','mohamad_a'),
   ('سارا کریی','sara123','sara_k'),
   ('علی رضایی','ali123','ali_r');


CREATE TABLE Students
( StudentID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DateOfBirth DATE,
    GradeLevel INT
    );
    INSERT INTO Students (StudentID, FirstName, LastName, GradeLevel) VALUES 
    (1, 'محمد', 'احمدی', 10),
    (2, 'سارا', 'کریمی', 9),
    (3, 'علی', 'رضایی', 11),
    (4, 'نازی', 'فراهانی', 8),
    (5, 'رضا', 'محمدی', 12);

    CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Subject NVARCHAR(100)
);
INSERT INTO Teachers (TeacherID, FirstName, LastName, Subject) VALUES 
    (1, 'مریم', 'کاظمی', 'ریاضی'),
    (2, 'سعید', 'اکبری', 'فیزیک'),
    (3, 'نگار', 'رحیمی', 'زبان انگلیسی'),
    (4, 'محمد', 'رضایی', 'شیمی'),
    (5, 'فاطمه', 'محمدی', 'ادبیات'),
    (6, 'علی', 'احمدی', 'تاریخ'),
    (7, 'نیما', 'صادقی', 'جغرافیا');


CREATE TABLE Grades (
    GradeID INT PRIMARY KEY,
    StudentID INT,
    Course NVARCHAR,
    Score DECIMAL(5, 2)
);
INSERT INTO Grades (GradeID, StudentID, Course, Score) VALUES
   (1, '1', 'ریاضی', '16'),
    (2, '2', 'فیزیک', '17'),
    (3, '3', 'زبان انگلیسی', '20 '),
    (4, '4', 'شیمی', '18'),
    (5, '5', 'ادبیات', '20'),
    (6, '2', 'تاریخ', '19'),
    (7, '4', 'جغرافیا', '18');


    CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName NVARCHAR(50),
    TeacherName NVARCHAR(50)
    );
    INSERT INTO Courses (CourseID, CourseName, TeacherName) VALUES
    (1,'ریاضی', 'مریم کاظمی'),
    (2, 'فیزیک', 'سعید اکبری'),
    (3, 'زبان انگلیسی', 'نگار رحیمی '),
    (4, 'شیمی', 'محمد رضایی'),
    (5, 'ادبیات', 'فاطمه محمدی'),
    (6, 'تاریخ', 'علی احمدی'),
    (7, 'جغرافیا', 'نیما صادقی');