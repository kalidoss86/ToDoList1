USE [TodoListDb]
GO

/****** Object: Table [dbo].[Task] Script Date: 23-06-2015 06:52:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Tasklist];


GO
CREATE TABLE [dbo].[Tasklist] (
    [id]              int  NOT NULL IDENTITY(1,1),
    [TaskTitle]       VARCHAR (50)  NOT NULL,
    [TaskDescription] VARCHAR (MAX) NULL,
    [DueDate]         DATETIME          NULL,
    [ReminderDate]    DATETIME          NULL,
    [Priority]        VARCHAR (10)    NOT NULL,
    [Category]        VARCHAR (50)  NULL
);

ALTER TABLE [dbo].[Tasklist] 
ADD PRIMARY KEY(id)

insert into Tasklist(TaskTitle, TaskDescription, DueDate, ReminderDate, Priority, Category)
values ('Buy Milk', 'Buy milk for tomorrow','2015-10-10', '2015-10-10', 'P01', 'Personal')

insert into Tasklist(TaskTitle, TaskDescription, DueDate, ReminderDate, Priority, Category)
values ('Book Appointment', 'Sample Desciption Text1','2015-9-9', '2015-9-9', 'P02', 'Personal')

insert into Tasklist(TaskTitle, TaskDescription, DueDate, ReminderDate, Priority, Category)
values ('Call to Wife', 'Sample Desciption Text2','2015-8-10', '2015-8-10', 'P01', 'Work')

insert into Tasklist(TaskTitle, TaskDescription, DueDate, ReminderDate, Priority, Category)
values ('Apply Passport', 'Sample Desciption Text3','2015-4-11', '2015-4-11', 'P03', 'Business')

insert into Tasklist(TaskTitle, TaskDescription, DueDate, ReminderDate, Priority, Category)
values ('Collect Courier', 'Sample Desciption Text5','2015-6-12', '2015-6-12', 'P05', 'Personal')
