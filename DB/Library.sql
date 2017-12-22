-- =========================================================
-- �������ݿ� Library 
-- =========================================================
CREATE DATABASE Library
--DROP DATABASE library
go
use Library
go
--=================================================================================================================
--�����û���
create table Users
(
	u_Name varchar(16) not null,
	u_Pass varchar(16) not null,
	u_Type char(8),
	u_Stopuser char(2)
)
insert into Users values ('cjp','110212','�����û�','��');
insert into Users values ('wlh','881104','��ͨ�û�','��');

--===================================================================================================================

--ͼ����ı�
create table Borrow
(
	Number int,   --���
	 CardID char(5)  not null, --����֤��
	 ReaderName varchar(10)  not null,  --��������
     BookID varchar(10),   --ͼ����
	 BookName varchar(20) not null,	--ͼ����
     Author varchar(20)  not null,	--����
     Publisher varchar(30),	--������
     Price int ,	--�۸�
	 BorrowDate varchar (16) not null,   --��������
     BorrowNumber   varchar(2),          --��������
     UserName varchar(10), --����Ա
     BroTieme varchar(3),  --����ʱ��
     IsOverdue    Char(2)	--�Ƿ���
	--primary key(BookID,CardID)
)
      insert into Borrow values('1','C0001','����','B0001','��ҳ��������','����','�廪������','22','2008-9-12','1','cjp','90','��');
	insert into Borrow values('2','C0007','���','B0002','C#�������','����','ˮ�繤�̳�����','45','2008-10-28','1','cjp','90','��');
	
    insert into Borrow values('3','C0001','����','B0003','���ʶ','�����','�廪������','18','2008-9-22','1','cjp','90','��');
	insert into Borrow values('4','C0004','����','B0002','C#�������','����','ˮ�繤�̳�����','45','2008-9-24','1','cjp','90','��');

	insert into Borrow values('5','C0006','������','B0003','���ʶ','�����','�廪������','18','2008-9-12','1','cjp','90','��');
	
    insert into Borrow values('6','C0006','������','B0004','�����Ӣ��','����','���ʳ�����','34','2008-10-11','1','cjp','90','��');
	insert into Borrow values('7','C0008','����','B0004','�����Ӣ��','����','���ʳ�����','34','2008-11-01','1','cjp','90','��');
	
    insert into Borrow values('8','C0009','������','B0003','���ʶ','�����','�廪������','18','2008-9-15','1','cjp','90','��');
	insert into Borrow values('9','C000A','������','B0002','C#�������','����','ˮ�繤�̳�����','45','2008-10-7','1','cjp','90','��');


--==========================================================================================================================================
--����������Ϣ��
go

create table Reader  
(
    Number int    not null ,--���
    CardID char(5)primary key,  --����֤��
    ReaderName varchar(10)   not null,	--��������
    BorrowNumber int,     --�ѽ���ͼ������ 
    Strichcode char(5) ,--������
    ReaderTypeID  char(10),--�������ͣ�1�����ʦ��2����ѧ��
    Mode varchar(10),--��֤״̬
    RegistrationTime varchar (16),--�Ǽ�����
    ValidTime varchar (16),--��Ч����
    Sex char(2),	--�Ա� 0--�� 1---Ů
    Dept varchar(20)  ,	--������λ
    Call varchar(15) --�绰

)
go

insert into  Reader values('1','C0001','����',2,'DZ001','��ʦ','��Ч','2008-9-12','2012-9-11','Ů','��ѵ��','13872343401');
insert into  Reader values('2','C0004','����',1,'DZ001','��ʦ','��Ч','2008-9-11','2012-9-11','Ů','��ѵ��','13872357701');
insert into  Reader values('3','C0006','������',2,'DZ001','ְ��','��Ч','2008-9-11','2012-9-11','��','���´�','13455129363');
insert into  Reader values('4','C0007','���',1,'DZ001','��ʦ','��Ч','2004-9-11','2008-9-11','��','����','13455129364');
insert into  Reader values('5','C0008','����',1,'DZ001','��ʦ','��Ч','2004-4-11','2008-9-11','��','����','13454563364');
insert into  Reader values('6','C0009','������',1,'DZ001','��ʦ','��Ч','2008-9-11','2012-9-11','��','ѧ��������','13455129366');
insert into  Reader values('7','C000A','������',1,'DZ001','ѧ��','��Ч','2008-9-11','2012-9-11','Ů','ѧ��������','');

--=================================================================================================================================
--�������ڱ�
create table OverdueInfo
(
	Number int  not null ,
	 CardID char(5)  not null, --����֤��
	 ReaderName varchar(10)  not null,  --��������
     BookID varchar(10),   --ͼ����
	 BookName varchar(20) not null,	--ͼ����
     Author varchar(20)  not null,	--����
     Publisher varchar(30),	--������
     Price int ,	--�۸�
	 BorrowDate varchar (16) not null,   --��������
     BorrowNumber   varchar(2),          --��������
     UserName varchar(10), --����Ա
     SpilthDay int --��������
	--primary key(BookID,CardID)
)
     -- insert into OverdueInfo values('C0001','����','B0001','��ҳ��������','����','�廪������','22','2008-9-12','1','cjp','0');
	--insert into OverdueInfo values('C0007','���','B0002','C#�������','����','ˮ�繤�̳�����','45','2008-10-28','1','cjp','0');
	
    --insert into OverdueInfo values('C0001','����','B0003','���ʶ','�����','�廪������','18','2008-9-22','1','cjp','0');
	--insert into OverdueInfo values('C0004','����','B0002','C#�������','����','ˮ�繤�̳�����','45','2008-9-24','1','cjp','0');

	--insert into OverdueInfo values('C0006','������','B0003','���ʶ','�����','�廪������','18','2008-9-12','1','cjp','0');
	
   -- insert into OverdueInfo values('C0006','������','B0004','�����Ӣ��','����','���ʳ�����','34','2008-10-11','1','cjp','0');
	--insert into OverdueInfo values('C0008','����','B0004','�����Ӣ��','����','���ʳ�����','34','2008-11-01','1','cjp','0');
	
   -- insert into OverdueInfo values('C0009','������','B0003','���ʶ','�����','�廪������','18','2008-9-15','1','cjp','0');
	--insert into OverdueInfo values('C000A','������','B0002','C#�������','����','ˮ�繤�̳�����','45','2008-10-7','1','cjp','0');
--==============================================================================================================================
go
--����ϵͳ��־��
create table Journal
(
  Number int not null, --���
  JournalName varchar(10) not null,--Ա������
  Status  varchar(10),--���
  EnterTime varchar (16)--����ʱ��
  primary key(EnterTime)
)
insert into Journal values('1','cjp','�����û�','2008-9-11');

--=================================================================================================================================
--����ͼ����Ϣ��
create table Book                     
(
    Number int  not null ,--���
    BookID varchar(10) primary key,	--ͼ����
    Strichcode varchar(10) ,--������
    SlassificationID varchar(5)  ,--�����
	BookName varchar(40) not null,	--ͼ����
    Type1 varchar(10) ,--����
	Author varchar(20)  not null,	--����
    Translator varchar(20),-- ����
    ISBN varchar(17),--ISBN��
    Publisher varchar(30),	--������
    Revision  varchar(8),--���
    Format varchar(2),--����
    Word int,--����
    Page int ,--ҳ��
    Price int ,	--�۸�
  	EnterTime varchar (16) not null,--���ʱ��
    Qty int	,--�����
    Extant int ,--�ɽ���
    Circulate bit --�Ƿ���ͨ
)
go
	insert into Book values('1','B0011','XS001','000AB','��ҳ��������','רҵ��','����','Freax','XORSE','�廪������','��һ��','16','235780','254','22','2006-01-08','20','19','0');
	insert into Book values('2','B0002','XS001','000AB','C#�������','רҵ��','����','Freac','XORSE','ˮ�繤�̳�����','�ڶ���','16','234345','341','45','2006-01-08','50','49','0');

	insert into Book values('3','B0003','XS001','100AB','���ʶ','������','�����','','XORSE','�廪������','��һ��','16','267688','349','18','2001-01-08','40','39','0');
	insert into Book values('4','B0004','XS001','100AB','�����Ӣ��','������','����','Freac','XORSE','���ʳ�����','�����','16','235676','419','34','2006-01-08','40','39','1');

	insert into Book values('5','B0005','XS001','000AB','ASP.NET���׽̳�','רҵ��','�⺣��','Freac','XORSE','���ʳ�����','�ڶ���','16','765474','389','69','2006-01-08','50','49','0');
	insert into Book values('6','B0006','XS001','100AB','60����Ͻ���֮��','������','���ع�','','XORSE','�廪������','��һ��','16','156577','443','15','2006-01-08','40','39','1');

	insert into Book values('7','B0007','XS001','000AB','JAVA�������','רҵ��','����','Freac','XORSE','��е��ҵ������','���İ�','16','768657','661','25','2006-01-08','20','19','0');
	insert into Book values('8','B0008','XS001','000AB','������װ��ά��','רҵ��','�Դ�ϼ','Freat','XORSE','��е��ҵ������','��һ��','16','257677','287','28','2006-01-08','20','19','0');

	insert into Book values('9','B0009','XS001','000AB','����','������','��־��','Freat','XORSE','��е��ҵ������','������','16','357651','1187','38','2006-01-08','20','19','0');
	insert into Book values('10','B0010','XS002','100AB','���ӵ繤����','רҵ��','�����','Freat','XORSE','�廪������','�ڶ���','16','557677','716','28','2006-01-08','20','19','1');
--======================================================================================================================
--������־��
create table Backupinfo 
(
	Number int not null, --���  
	lodUser varchar(12) not null,   --��¼�û�
	BackupTime varchar(16) not null,    --��¼ʱ��
	Type varchar(10) , --��������
	BackupWay varchar(100) ,    --����·��
)
insert into Backupinfo values ('1','cjp','2008-12-3','���ݿ⻹ԭ','C:\');


--==========================================================================================================================
--������־
create table HandleNote
(
	HandleNumber  int not null ,     --������ˮ��
	HandleType varchar(8) not null,    --�������
	HandleUser   varchar(12) not null,       --�����û�
	BookName  varchar(20),     --ͼ������
	BookStrichcode   varchar(10)   not null, --ͼ����
	ReaderID    char(5)  	not null,--���߿���
	ReaderName   varchar(10),	--��������
	ReaderSex    char(2),	    --�����Ա�
	BookNumber    varchar(2),	      --��������
	BookPrice     int,        --ͼ��۸�
        HandleDate  varchar (16)--��������
)
insert into HandleNote values('1','�黹����','cjp','JAVA�������','B0007','C000A','������','Ů','1','25','2006-12-08 08:10')
insert into HandleNote values('2','���Ĳ���','cjp','C#�������','B0002','C0006','������','��','1','25','2008-12-25 08:10')

--=======================================================================================================================
--����Ԥ���
create table ReserBroInfo
(
	r_Number     int  , --���
	r_BookId  varchar(10) not null,   --ͼ����
	r_BookName   varchar(40) not null,     --ͼ������
	r_BookAuthor	varchar(20),         --ͼ������
	r_ReaderId  char(5)  not null,      --���߱��
	r_ReaderName  varchar(10)  not null,       --��������
	r_ReaderSex   char(2),       --�����Ա�
	r_BookNumber   varchar(2),        --Ԥ������
	r_BookPrice    int,         --ͼ��۸�
        r_Publisher    varchar (30),    --������
        r_HandleUsr   varchar(16),	--�����û�
	r_ReadyTime   varchar (16)		--Ԥ��ʱ��
	
) 	
insert into ReserBroInfo values ('1','B0011','��ҳ��������','����','C0001','����','��','1','22','�廪������','cjp','2008-12-28 9:00')
--===================================================================================================================
 --������־��
create table PenaltryInfo
(
Number int  not null, --��� 
CardID	Char(5) not null,  --���߱��
ReaderName	Varchar(10) not null,	--��������
BookName	Varchar(40) not null,	--ͼ������
BookID	Varchar(10) not null,--ͼ����
Type	Varchar(20),	--��������   ���𻵡����ڣ�
PenaltyMoney	money ,	--������
Paytime	varchar(16),	--����ʱ�� (Ԫ)
HandleUser	Varchar (12)	--�����û�
)
insert into PenaltryInfo values('1','C0007','���','���ӵ繤����','B0010','ͼ����',5,'2008-12-3','cjp');
insert into PenaltryInfo values('2','C0008','����','C#�������','B0002','����ĩ��',4.5,'2008-12-3','cjp');
--=====================================================================================================================
--������Ϣ��
create table RenewNote
(
	Number int  not null ,--���
	CardID	Char (5),  --����֤��
	ReaderName	varChar (10),--	��������
	BookID	Char (10)	,--ͼ����
	BookName	Varchar (20),--	ͼ������
	Author	Varchar (20),--	ͼ������
	Publisher	varchar (30),--	ͼ�������
	Price	Int 	,--ͼ��۸�
	BorrowDate	varchar (16),--	����ʱ��
	UserName	Varchar (10)	--����Ա
)
Insert into RenewNote values('1','C0009','������','B0003','���ʶ','�����','�廪������','18','2008-9-23','whl');
--===============================================================================================================
--��������Ϣ
create table Publishing
(
PulNumber int,  --���
PulName	Varchar(30) primary key not null	,--����������
PulAdress	Varchar (50),	--��ַ
PulExplain	Varchar (100),	--˵��
)
--delete from Publishing
insert into Publishing values('1','��е��ҵ������','','');
insert into Publishing values('2','������ѧ������','','');
insert into Publishing values('3','������ѧ������','','');
insert into Publishing values('4','�Ϻ����������','','');
insert into Publishing values('5','ɽ����ѧ������','','');
insert into Publishing values('6','�����ƾ���ѧ������','','');
insert into Publishing values('7','�������Դ�ѧ������','','');
insert into Publishing values('8','�ߵȽ���������','','');
insert into Publishing values('9','����ʦ��������','','');
insert into Publishing values('10','�������������','','');
insert into Publishing values('11','������ѧ������','','');
insert into Publishing values('12','�й������ѧ������','','');
insert into Publishing values('13','�й��Ṥҵ������','','');
insert into Publishing values('14','�й���ٿƳ�����','','');
insert into Publishing values('15','�й����ڳ�����','','');
insert into Publishing values('16','�й�������淭�빫˾','','');
insert into Publishing values('17','�й�����ѧ������','','');
insert into Publishing values('18','�й���ͼ������','','');
insert into Publishing values('19','�й�����������','','');
insert into Publishing values('20','�й�������ѧ������','','');
insert into Publishing values('21','�����ʵ������','','');
insert into Publishing values('22','��ѧ������','','');
insert into Publishing values('23','��������������','','');
insert into Publishing values('24','���ɳ�����','','');
insert into Publishing values('25','�й�ˮ��ˮ�������','','');
insert into Publishing values('26','��ѧ��ҵ������','','');
insert into Publishing values('27','�����ʵ��е��ҵ������','','');
insert into Publishing values('28','���ӹ�ҵ������','','');
insert into Publishing values('29','����֪ʶ������','','');
--============================================================================================================
--ϵͳ���ñ�
create table SystemSet
(
	TeaBroNumber int,   --��ʦ�ɽ�������
	StuBroNumber int,     --ѧ���ɽ�������
        PayMoney     varchar (3),  --������Ŀ
	SetReserDay      int ,   --Ԥ����Ч����
        IsOpenOverdue  char(2)  --�Ƿ�����ڱ�
)
  insert into SystemSet values (10,4,'0.2','15','��');

--=============================================================================================================================
--����������
create table Remind
(
     Number int,--�������
     Statue  char (8), --��ǰ״̬
     RemindTime varchar (20) ,--����ʱ��
     Content varchar (100) ,--��������
     IsRemind  char (2),--�Ƿ���ʾ
     Type varchar (20),--��ʾ��ʽ
     IsToReader varchar (10), --�Ƿ��漰����
     Addtime  varchar (20)  --�������ʱ��
)
insert into Remind values(1,'��δ��ʾ','2008-12-30 00:00:000','����Ҫ���ñ������壡','��','һ������','������','2008-12-29 00:00:000');

--==========================================================================================================================
