create database DBLabProject
use DBLabProject;



create table tblUser
(
    username varchar(20) not null,
    password varchar(20) not null,
    name varchar(20) not null,
    role varchar(20) not null,
    isActive bit not null,
    check (role in ('Student', 'Teacher', 'Admin')),
    -- Primary key  
    primary key (username)
)

create table Classroom
(
    classroomID int IDENTITY(1,1) not null,
    classroomName varchar(20) not null,
    classroomCode varchar(20) not null unique,
    teacherUsername varchar(20) not null,
    -- Primary key
    primary key (classroomID),
    -- Foreign key
    foreign key (teacherUsername) references tblUser(username) on delete cascade

)

create table ClassroomAndStudent
(
    -- username from User
    studentusername varchar(20) not null,
    -- classroomID from Classroom
    classroomID int not null,
    -- Primary key
    primary key (studentusername, classroomID),
    -- Foreign key
    foreign key (studentusername) references tblUser(username),
    foreign key (classroomID) references Classroom(classroomID) on delete cascade
)

create table Announcement
(
    announcementID int IDENTITY(1,1) not null,
    announcementTitle varchar(100) not null,
    announcementDescription varchar(100) not null,
    announcementDate DATETIME not null,
    username_Teacher varchar(20) not null,
    announcementFile varchar(100),
    classroomID int not null,
    -- Primary key
    primary key (announcementID),
    -- Foreign key
    foreign key (username_Teacher) references tblUser(username),
    foreign key (classroomID) references Classroom(classroomID) on delete cascade
)

-- insert into announcement values ('test', 'test', '2021-05-05', 'admin', 'test', 1)



create table Material
(
    materialID int IDENTITY(1,1) not null,
    materialTitle varchar(100) not null,
    materialDescription varchar(100) not null,
    materialType varchar(100) not null,
    username_Teacher varchar(20) not null,
    classroomID int not null,
    -- Primary key
    primary key (materialID),
    -- Foreign key
    foreign key (username_Teacher) references tblUser(username),
    foreign key (classroomID) references Classroom(classroomID) on delete cascade
)

create table Assignment
(
    assignmentID int IDENTITY(1,1) not null,
    assignmentTitle varchar(100) not null,
    assignmentDescription varchar(255) not null,
    assignmentPoints int not null,
    assignmentDueDate DATETIME,
    assignmentFile varchar(100),
    classroomID int not null,
    username_Teacher varchar(20) not null,
    -- Primary key 
    primary key (assignmentID),
    -- Foreign key
    foreign key (username_Teacher) references tblUser(username),
    foreign key (classroomID) references Classroom(classroomID) on delete cascade
)

CREATE TABLE Submissions
(
    -- username from User
    studentusername varchar(20) not null,
    -- assignmentID from Assignment
    assignmentID int not null,
    submissionFile varchar(100),
    submissionDate date,
    submissionPoints int,
    -- Primary key
    primary key (studentusername, assignmentID),
    -- Foreign key
    foreign key (studentusername) references tblUser(username),
    foreign key (assignmentID) references Assignment(assignmentID) on DELETE CASCADE
)

create table Comment
(
    commentID int IDENTITY(1,1) not null,
    commentDescription varchar(100) not null,
    commentDate date not null,
    assignmentID int not null,
    commentUserName varchar(20) not null,
    -- Primary key
    primary key (commentID),
    -- Foreign key
    foreign key (assignmentID) references Assignment(assignmentID) on delete cascade,
    foreign key (commentUserName) references tblUser(username)
)



drop table Comment

create table announcementComment
(
    announcementCommentID int identity(1,1) not null,
    announcementID int not null,
    commentUserName varchar(20) not null,
    commentDescription varchar(100) not null,
    commentDate date not null,
    -- Primary key
    primary key (announcementCommentID),
    foreign key (announcementID) references Announcement(announcementID) on DELETE CASCADE,
    foreign key (commentUserName) references tblUser(username)
)