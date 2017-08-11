using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Function;
using Function.Db;
using System.Data;

namespace GM_Torqu_Tool_IF
{
	/// <summary>
	/// 데이터 베이스 초기화
	/// </summary>
	class dba_init
	{
		
		/// <summary>
		/// data base를 생성 한다.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="dbName"></param>
		/// <param name="path"></param>
		public static void db_create(MsSQL.strConnect conn, string dbName, string path)
		{
			MsSQL sql = new MsSQL(conn);

			string qry = string.Format(@"
CREATE DATABASE [{0}] ON  PRIMARY 
( NAME = N'{0}', FILENAME = N'{1}{0}.mdf' , SIZE = 204800KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'{0}_log', FILENAME = N'{1}{0}.ldf' , SIZE = 51200KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)


ALTER DATABASE [{0}] SET COMPATIBILITY_LEVEL = 100


IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [{0}].[dbo].[sp_fulltext_database] @action = 'enable'
end


ALTER DATABASE [{0}] SET ANSI_NULL_DEFAULT OFF 


ALTER DATABASE [{0}] SET ANSI_NULLS OFF 


ALTER DATABASE [{0}] SET ANSI_PADDING OFF 


ALTER DATABASE [{0}] SET ANSI_WARNINGS OFF 


ALTER DATABASE [{0}] SET ARITHABORT OFF 


ALTER DATABASE [{0}] SET AUTO_CLOSE ON 


ALTER DATABASE [{0}] SET AUTO_SHRINK OFF 


ALTER DATABASE [{0}] SET AUTO_UPDATE_STATISTICS ON 


ALTER DATABASE [{0}] SET CURSOR_CLOSE_ON_COMMIT OFF 


ALTER DATABASE [{0}] SET CURSOR_DEFAULT  GLOBAL 


ALTER DATABASE [{0}] SET CONCAT_NULL_YIELDS_NULL OFF 


ALTER DATABASE [{0}] SET NUMERIC_ROUNDABORT OFF 


ALTER DATABASE [{0}] SET QUOTED_IDENTIFIER OFF 


ALTER DATABASE [{0}] SET RECURSIVE_TRIGGERS OFF 


ALTER DATABASE [{0}] SET  DISABLE_BROKER 


ALTER DATABASE [{0}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 


ALTER DATABASE [{0}] SET DATE_CORRELATION_OPTIMIZATION OFF 


ALTER DATABASE [{0}] SET TRUSTWORTHY OFF 


ALTER DATABASE [{0}] SET ALLOW_SNAPSHOT_ISOLATION OFF 


ALTER DATABASE [{0}] SET PARAMETERIZATION SIMPLE 


ALTER DATABASE [{0}] SET READ_COMMITTED_SNAPSHOT OFF 


ALTER DATABASE [{0}] SET HONOR_BROKER_PRIORITY OFF 


ALTER DATABASE [{0}] SET RECOVERY SIMPLE 


ALTER DATABASE [{0}] SET  MULTI_USER 


ALTER DATABASE [{0}] SET PAGE_VERIFY CHECKSUM  


ALTER DATABASE [{0}] SET DB_CHAINING OFF 


ALTER DATABASE [{0}] SET  READ_WRITE 
", dbName, path);

			sql.Excute_Query(qry, "");

		}



		public static void tables_create(MsSQL.strConnect conn)
		{
			MsSQL sql = new MsSQL(conn);

			string qry = @"
CREATE TABLE [dbo].[T_Result](
	[CreateDate] [datetime] NOT NULL,
	[PONO] [nvarchar](6) NOT NULL,
	[TrimInSeq] [nvarchar](4) NOT NULL,
	[VIN] [nvarchar](17) NOT NULL,
	[CarType] [nvarchar](3) NOT NULL,
	[TotalResult] [nvarchar](2) NULL,
	[STATION_ID] [nchar](10) NOT NULL,
	[T01_N01] [nvarchar](4) NULL,
	[T01_N02] [nvarchar](4) NULL,
	[T01_N03] [nvarchar](2) NULL,
	[T02_N01] [nvarchar](4) NULL,
	[T02_N02] [nvarchar](4) NULL,
	[T02_N03] [nvarchar](2) NULL,
	[T03_N01] [nvarchar](4) NULL,
	[T03_N02] [nvarchar](4) NULL,
	[T03_N03] [nvarchar](2) NULL,
	[T04_N01] [nvarchar](4) NULL,
	[T04_N02] [nvarchar](4) NULL,
	[T04_N03] [nvarchar](2) NULL,
	[T05_N01] [nvarchar](4) NULL,
	[T05_N02] [nvarchar](4) NULL,
	[T05_N03] [nvarchar](2) NULL,
	[T06_N01] [nvarchar](4) NULL,
	[T06_N02] [nvarchar](4) NULL,
	[T06_N03] [nvarchar](2) NULL,
	[T07_N01] [nvarchar](4) NULL,
	[T07_N02] [nvarchar](4) NULL,
	[T07_N03] [nvarchar](2) NULL,
	[T08_N01] [nvarchar](4) NULL,
	[T08_N02] [nvarchar](4) NULL,
	[T08_N03] [nvarchar](2) NULL,
	[T09_N01] [nvarchar](4) NULL,
	[T09_N02] [nvarchar](4) NULL,
	[T09_N03] [nvarchar](2) NULL,
	[T10_N01] [nvarchar](4) NULL,
	[T10_N02] [nvarchar](4) NULL,
	[T10_N03] [nvarchar](2) NULL,
	[T11_N01] [nvarchar](4) NULL,
	[T11_N02] [nvarchar](4) NULL,
	[T11_N03] [nvarchar](2) NULL,
	[T12_N01] [nvarchar](4) NULL,
	[T12_N02] [nvarchar](4) NULL,
	[T12_N03] [nvarchar](2) NULL,
	[T13_N01] [nvarchar](4) NULL,
	[T13_N02] [nvarchar](4) NULL,
	[T13_N03] [nvarchar](2) NULL,
	[T14_N01] [nvarchar](4) NULL,
	[T14_N02] [nvarchar](4) NULL,
	[T14_N03] [nvarchar](2) NULL,
	[T15_N01] [nvarchar](4) NULL,
	[T15_N02] [nvarchar](4) NULL,
	[T15_N03] [nvarchar](2) NULL,
	[T16_N01] [nvarchar](4) NULL,
	[T16_N02] [nvarchar](4) NULL,
	[T16_N03] [nvarchar](2) NULL,
	[T17_N01] [nvarchar](4) NULL,
	[T17_N02] [nvarchar](4) NULL,
	[T17_N03] [nvarchar](2) NULL,
	[T18_N01] [nvarchar](4) NULL,
	[T18_N02] [nvarchar](4) NULL,
	[T18_N03] [nvarchar](2) NULL,
	[T19_N01] [nvarchar](4) NULL,
	[T19_N02] [nvarchar](4) NULL,
	[T19_N03] [nvarchar](2) NULL,
	[T20_N01] [nvarchar](4) NULL,
	[T20_N02] [nvarchar](4) NULL,
	[T20_N03] [nvarchar](2) NULL,
	[T21_N01] [nvarchar](4) NULL,
	[T21_N02] [nvarchar](4) NULL,
	[T21_N03] [nvarchar](2) NULL,
	[T22_N01] [nvarchar](4) NULL,
	[T22_N02] [nvarchar](4) NULL,
	[T22_N03] [nvarchar](2) NULL,
	[T23_N01] [nvarchar](4) NULL,
	[T23_N02] [nvarchar](4) NULL,
	[T23_N03] [nvarchar](2) NULL,
	[T24_N01] [nvarchar](4) NULL,
	[T24_N02] [nvarchar](4) NULL,
	[T24_N03] [nvarchar](2) NULL,
	[T25_N01] [nvarchar](4) NULL,
	[T25_N02] [nvarchar](4) NULL,
	[T25_N03] [nvarchar](2) NULL,
	[IFFLAG] [nchar](1) NULL CONSTRAINT [DF_T_Result_IFFLAG]  DEFAULT ('N'),
	[IFDATE] [datetime] NULL,
 CONSTRAINT [PK_TResult] PRIMARY KEY CLUSTERED 
(
	[CreateDate] ASC,
	[STATION_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE NONCLUSTERED INDEX [IDX_RESULT_IFFLAG] ON [dbo].[T_Result]
(
	[IFFLAG] ASC,
	[STATION_ID] ASC,
	[CreateDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO




CREATE TABLE [dbo].[T_CODE](
	[COMPANY_ID] [nvarchar](10) NOT NULL,
	[PROG_ID] [nvarchar](10) NOT NULL,
	[CODE] [nvarchar](10) NOT NULL,
	[CODENAME] [nvarchar](100) NULL,
	[CODETYPE] [nvarchar](1) NULL,
	[INFO1DESC] [nvarchar](50) NULL,
	[INFO1TYPE] [nvarchar](10) NULL,
	[INFO2DESC] [nvarchar](50) NULL,
	[INFO2TYPE] [nvarchar](10) NULL,
	[INFO3DESC] [nvarchar](50) NULL,
	[INFO3TYPE] [nvarchar](10) NULL,
	[INFO4DESC] [nvarchar](50) NULL,
	[INFO4TYPE] [nvarchar](10) NULL,
	[INFO5DESC] [nvarchar](50) NULL,
	[INFO5TYPE] [nvarchar](10) NULL,
	[CREATEDATE] [date] NULL,
	[CREATEUSER] [nvarchar](10) NULL,
	[LASTUPDATEDATE] [date] NULL,
	[LASTUPDATEUSER] [nvarchar](10) NULL,
 CONSTRAINT [PK_T_CODE] PRIMARY KEY CLUSTERED 
(
	[COMPANY_ID] ASC,
	[PROG_ID] ASC,
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[T_CODEDETAIL](
	[COMPANY_ID] [nvarchar](10) NOT NULL,
	[PROG_ID] [nvarchar](10) NOT NULL,
	[CODE] [nvarchar](10) NOT NULL,
	[CODEVALUE] [nvarchar](10) NOT NULL,
	[CODEVALUENAME] [nvarchar](100) NULL,
	[INFO1] [nvarchar](100) NULL,
	[INFO2] [nvarchar](100) NULL,
	[INFO3] [nvarchar](100) NULL,
	[INFO4] [nvarchar](100) NULL,
	[INFO5] [nvarchar](100) NULL,
	[CREATEDATE] [date] NULL,
	[CREATEUSER] [nvarchar](10) NULL,
	[LASTUPDATEDATE] [date] NULL,
	[LASTUPDATEUSER] [nvarchar](10) NULL,
	[PRIORITY] [int] NULL,
 CONSTRAINT [PK_T_CODEDETAIL] PRIMARY KEY CLUSTERED 
(
	[COMPANY_ID] ASC,
	[PROG_ID] ASC,
	[CODE] ASC,
	[CODEVALUE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

";

			sql.Excute_Query(qry, "");
		}


		/// <summary>
		/// 기초 데이터를 입력 하여 준다.
		/// </summary>
		/// <param name="conn"></param>
		public static void data_insert(MsSQL.strConnect conn)
		{
			MsSQL sql = new MsSQL(conn);

			string qry = @"
Insert into T_CODE (COMPANY_ID,  PROG_ID, CODE, CODENAME, CODETYPE ) values ( 'GM', 'TORQUE', 'DEV_NAME', '장비이름', 'S');
Insert into T_CODE (COMPANY_ID,  PROG_ID, CODE, CODENAME, CODETYPE ) values ( 'GM', 'TORQUE', 'RST_NAME', '결과 이름', 'S');
Insert into T_CODE (COMPANY_ID,  PROG_ID, CODE, CODENAME, CODETYPE ) values ( 'GM', 'TORQUE', 'TOOL_NAME', '툴 이름', 'S');

Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'DEV_NAME', 'DEV_01', '1호기', '0');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'DEV_NAME', 'DEV_02', '2호기', '1');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'RST_NAME', 'N01', 'Torque', '0');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'RST_NAME', 'N02', 'Angle', '1');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'RST_NAME', 'N03', 'SUB', '2');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T01', 'N01', '0');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T02', 'N02', '1');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T03', 'N03', '2');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T04', 'N04', '3');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T05', 'N05', '4');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T06', 'N06', '5');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T07', 'N07', '6');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T08', 'N08', '7');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T09', 'N11', '8');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T10', 'N12A', '9');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T11', 'N12B', '10');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T12', 'N13', '11');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T13', 'N14A', '12');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T14', 'N14B', '13');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T15', 'N15A', '14');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T16', 'N15B', '15');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T17', 'N16A', '16');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T18', 'N16B', '17');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T19', 'N17A', '18');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T20', 'N17B', '19');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T21', 'N18A', '20');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T22', 'N18B', '21');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T23', '', '22');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T24', '', '23');
Insert into T_CODEDETAIL ([COMPANY_ID], [PROG_ID], [CODE], [CODEVALUE], [CODEVALUENAME], PRIORITY ) values ( 'GM', 'TORQUE', 'TOOL_NAME', 'T25', '', '24');

";

			sql.Excute_Query(qry, "");
		}


		/// <summary>
		/// 상대 db 링크를 만들어 낸다.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="ip"></param>
		/// <param name="id"></param>
		/// <param name="pass"></param>
		public static void db_link_create(MsSQL.strConnect conn, string ip, string id, string pass)
		{
			MsSQL sql = new MsSQL(conn);

			string qry = string.Format(@"
EXEC master.dbo.sp_addlinkedserver @server = N'LNK_TORQUE', @srvproduct=N'torque_lnk', @provider=N'SQLNCLI', @datasrc=N'{0}'

EXEC master.dbo.sp_addlinkedsrvlogin @rmtsrvname=N'LNK_TORQUE',@useself=N'False',@locallogin=NULL,@rmtuser=N'{1}',@rmtpassword='{2}'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'collation compatible', @optvalue=N'false'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'data access', @optvalue=N'true'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'dist', @optvalue=N'false'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'pub', @optvalue=N'false'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'rpc', @optvalue=N'false'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'rpc out', @optvalue=N'false'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'sub', @optvalue=N'false'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'connect timeout', @optvalue=N'0'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'collation name', @optvalue=null

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'lazy schema validation', @optvalue=N'false'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'query timeout', @optvalue=N'0'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'use remote collation', @optvalue=N'true'

EXEC master.dbo.sp_serveroption @server=N'LNK_TORQUE', @optname=N'remote proc transaction promotion', @optvalue=N'true'"
, ip, id, pass);

			sql.Excute_Query(qry, "");
		}

		/// <summary>
		/// if 처리 프로시져를 만들어 준다.
		/// </summary>
		/// <param name="conn"></param>
		public static void if_proc_create(MsSQL.strConnect conn)
		{
			MsSQL sql = new MsSQL(conn);

			string qry = @"
-- =============================================
-- Author:		CSW
-- Create date: 2017.07.28
-- Description:	V0.1
-- =============================================
Create PROCEDURE [dbo].[P_RESULT_IF]	
AS
DECLARE @DT1	AS DATETIME,
	@DT2	AS DATETIME,
	@CreateDate datetime ,
	@PONO nvarchar(6) ,
	@TrimInSeq nvarchar(4) ,
	@VIN nvarchar(17) ,
	@CarType nvarchar(3) ,
	@TotalResult nvarchar(2),
	@STATION_ID nchar(10) ,
	@T01_N01 nvarchar(4),
	@T01_N02 nvarchar(4),
	@T01_N03 nvarchar(2),
	@T02_N01 nvarchar(4),
	@T02_N02 nvarchar(4),
	@T02_N03 nvarchar(2),
	@T03_N01 nvarchar(4),
	@T03_N02 nvarchar(4),
	@T03_N03 nvarchar(2),
	@T04_N01 nvarchar(4),
	@T04_N02 nvarchar(4),
	@T04_N03 nvarchar(2),
	@T05_N01 nvarchar(4),
	@T05_N02 nvarchar(4),
	@T05_N03 nvarchar(2),
	@T06_N01 nvarchar(4),
	@T06_N02 nvarchar(4),
	@T06_N03 nvarchar(2),
	@T07_N01 nvarchar(4),
	@T07_N02 nvarchar(4),
	@T07_N03 nvarchar(2),
	@T08_N01 nvarchar(4),
	@T08_N02 nvarchar(4),
	@T08_N03 nvarchar(2),
	@T09_N01 nvarchar(4),
	@T09_N02 nvarchar(4),
	@T09_N03 nvarchar(2),
	@T10_N01 nvarchar(4),
	@T10_N02 nvarchar(4),
	@T10_N03 nvarchar(2),
	@T11_N01 nvarchar(4),
	@T11_N02 nvarchar(4),
	@T11_N03 nvarchar(2),
	@T12_N01 nvarchar(4),
	@T12_N02 nvarchar(4),
	@T12_N03 nvarchar(2),
	@T13_N01 nvarchar(4),
	@T13_N02 nvarchar(4),
	@T13_N03 nvarchar(2),
	@T14_N01 nvarchar(4),
	@T14_N02 nvarchar(4),
	@T14_N03 nvarchar(2),
	@T15_N01 nvarchar(4),
	@T15_N02 nvarchar(4),
	@T15_N03 nvarchar(2),
	@T16_N01 nvarchar(4),
	@T16_N02 nvarchar(4),
	@T16_N03 nvarchar(2),
	@T17_N01 nvarchar(4),
	@T17_N02 nvarchar(4),
	@T17_N03 nvarchar(2),
	@T18_N01 nvarchar(4),
	@T18_N02 nvarchar(4),
	@T18_N03 nvarchar(2),
	@T19_N01 nvarchar(4),
	@T19_N02 nvarchar(4),
	@T19_N03 nvarchar(2),
	@T20_N01 nvarchar(4),
	@T20_N02 nvarchar(4),
	@T20_N03 nvarchar(2),
	@T21_N01 nvarchar(4),
	@T21_N02 nvarchar(4),
	@T21_N03 nvarchar(2),
	@T22_N01 nvarchar(4),
	@T22_N02 nvarchar(4),
	@T22_N03 nvarchar(2),
	@T23_N01 nvarchar(4),
	@T23_N02 nvarchar(4),
	@T23_N03 nvarchar(2),
	@T24_N01 nvarchar(4),
	@T24_N02 nvarchar(4),
	@T24_N03 nvarchar(2),
	@T25_N01 nvarchar(4),
	@T25_N02 nvarchar(4),
	@T25_N03 nvarchar(2),
	@cnt int,
	@TCnt int
BEGIN	
	
	SET @DT1 = GETDATE()
	set @cnt = 0

	PRINT '작업 시작' + CONVERT(VARCHAR(20), @DT1,120)

	--전체 대상 조회
	SELECT @TCnt = COUNT(*)
	FROM [LNK_TORQUE].[TorqueTool].[dbo].[T_Result] R
	WHERE IFFLAG = 'N'
	AND STATION_ID IN
	(
		SELECT CODEVALUE FROM T_CODEDETAIL WHERE COMPANY_ID = 'GM' AND CODE = 'DEV_NAME' AND PROG_ID = 'TORQUE' AND INFO1 = 'N'
	)
	AND NOT EXISTS (SELECT CreateDate, STATION_ID FROM T_RESULT T WHERE T.CreateDate = R.CreateDate AND T.STATION_ID = R.STATION_ID)


	--돌면서작업할커서확인..
	declare CusorInterface CURSOR  
	LOCAL  
	FORWARD_ONLY  
	STATIC --static:이후에반영되는데이터를감지못함/key set:키의삭제수정에대해서는감지insert에대해서는감지못함/dynamic:모두감지
	READ_ONLY  
	FOR  
	SELECT TOP 100 CreateDate, PONO, TrimInSeq, VIN, CarType, TotalResult, STATION_ID, T01_N01, T01_N02, T01_N03, T02_N01, T02_N02, T02_N03, T03_N01, T03_N02, T03_N03, T04_N01, 
               T04_N02, T04_N03, T05_N01, T05_N02, T05_N03, T06_N01, T06_N02, T06_N03, T07_N01, T07_N02, T07_N03, T08_N01, T08_N02, T08_N03, T09_N01, T09_N02, T09_N03, T10_N01, 
               T10_N02, T10_N03, T11_N01, T11_N02, T11_N03, T12_N01, T12_N02, T12_N03, T13_N01, T13_N02, T13_N03, T14_N01, T14_N02, T14_N03, T15_N01, T15_N02, T15_N03, T16_N01, 
               T16_N02, T16_N03, T17_N01, T17_N02, T17_N03, T18_N01, T18_N02, T18_N03, T19_N01, T19_N02, T19_N03, T20_N01, T20_N02, T20_N03, T21_N01, T21_N02, T21_N03, T22_N01, 
               T22_N02, T22_N03, T23_N01, T23_N02, T23_N03, T24_N01, T24_N02, T24_N03, T25_N01, T25_N02, T25_N03
	FROM [LNK_TORQUE].[TorqueTool].[dbo].[T_Result] R
	WHERE IFFLAG = 'N'
	AND STATION_ID IN
	(
		SELECT CODEVALUE FROM T_CODEDETAIL WHERE COMPANY_ID = 'GM' AND CODE = 'DEV_NAME' AND PROG_ID = 'TORQUE' AND INFO1 = 'N'
	)
	AND NOT EXISTS (SELECT CreateDate, STATION_ID FROM T_RESULT T WHERE T.CreateDate = R.CreateDate AND T.STATION_ID = R.STATION_ID)


	--2.인터페이별로작업을처리한다.
	OPEN CusorInterface  
	Fetch next from CusorInterface into 
		@CreateDate, @PONO, @TrimInSeq, @VIN, @CarType, @TotalResult, @STATION_ID, @T01_N01, @T01_N02, @T01_N03, @T02_N01, @T02_N02, @T02_N03, @T03_N01, @T03_N02, @T03_N03, @T04_N01, 
		@T04_N02, @T04_N03, @T05_N01, @T05_N02, @T05_N03, @T06_N01, @T06_N02, @T06_N03, @T07_N01, @T07_N02, @T07_N03, @T08_N01, @T08_N02, @T08_N03, @T09_N01, @T09_N02, @T09_N03, @T10_N01, 
		@T10_N02, @T10_N03, @T11_N01, @T11_N02, @T11_N03, @T12_N01, @T12_N02, @T12_N03, @T13_N01, @T13_N02, @T13_N03, @T14_N01, @T14_N02, @T14_N03, @T15_N01, @T15_N02, @T15_N03, @T16_N01, 
		@T16_N02, @T16_N03, @T17_N01, @T17_N02, @T17_N03, @T18_N01, @T18_N02, @T18_N03, @T19_N01, @T19_N02, @T19_N03, @T20_N01, @T20_N02, @T20_N03, @T21_N01, @T21_N02, @T21_N03, @T22_N01, 
		@T22_N02, @T22_N03, @T23_N01, @T23_N02, @T23_N03, @T24_N01, @T24_N02, @T24_N03, @T25_N01, @T25_N02, @T25_N03
	WHILE @@FETCH_STATUS=0  
	begin 

		--데이터 인서트
		INSERT INTO T_RESULT
		(
			CreateDate, PONO, TrimInSeq, VIN, CarType, TotalResult, STATION_ID, T01_N01, T01_N02, T01_N03, T02_N01, T02_N02, T02_N03, T03_N01, T03_N02, T03_N03, T04_N01, 
			T04_N02, T04_N03, T05_N01, T05_N02, T05_N03, T06_N01, T06_N02, T06_N03, T07_N01, T07_N02, T07_N03, T08_N01, T08_N02, T08_N03, T09_N01, T09_N02, T09_N03, T10_N01, 
			T10_N02, T10_N03, T11_N01, T11_N02, T11_N03, T12_N01, T12_N02, T12_N03, T13_N01, T13_N02, T13_N03, T14_N01, T14_N02, T14_N03, T15_N01, T15_N02, T15_N03, T16_N01, 
			T16_N02, T16_N03, T17_N01, T17_N02, T17_N03, T18_N01, T18_N02, T18_N03, T19_N01, T19_N02, T19_N03, T20_N01, T20_N02, T20_N03, T21_N01, T21_N02, T21_N03, T22_N01, 
			T22_N02, T22_N03, T23_N01, T23_N02, T23_N03, T24_N01, T24_N02, T24_N03, T25_N01, T25_N02, T25_N03, 
			IFFLAG, IFDATE
		)
		VALUES
		(
			@CreateDate, @PONO, @TrimInSeq, @VIN, @CarType, @TotalResult, @STATION_ID, @T01_N01, @T01_N02, @T01_N03, @T02_N01, @T02_N02, @T02_N03, @T03_N01, @T03_N02, @T03_N03, @T04_N01, 
			@T04_N02, @T04_N03, @T05_N01, @T05_N02, @T05_N03, @T06_N01, @T06_N02, @T06_N03, @T07_N01, @T07_N02, @T07_N03, @T08_N01, @T08_N02, @T08_N03, @T09_N01, @T09_N02, @T09_N03, @T10_N01, 
			@T10_N02, @T10_N03, @T11_N01, @T11_N02, @T11_N03, @T12_N01, @T12_N02, @T12_N03, @T13_N01, @T13_N02, @T13_N03, @T14_N01, @T14_N02, @T14_N03, @T15_N01, @T15_N02, @T15_N03, @T16_N01, 
			@T16_N02, @T16_N03, @T17_N01, @T17_N02, @T17_N03, @T18_N01, @T18_N02, @T18_N03, @T19_N01, @T19_N02, @T19_N03, @T20_N01, @T20_N02, @T20_N03, @T21_N01, @T21_N02, @T21_N03, @T22_N01, 
			@T22_N02, @T22_N03, @T23_N01, @T23_N02, @T23_N03, @T24_N01, @T24_N02, @T24_N03, @T25_N01, @T25_N02, @T25_N03,
			'T', GETDATE()
		)

		--ifflag update
		UPDATE [LNK_TORQUE].[TorqueTool].[dbo].[T_Result]
		SET IFFLAG = 'Y',
			IFDATE = GETDATE()
		WHERE CreateDate = @CreateDate
			AND STATION_ID = @STATION_ID

		set @cnt = @CNT + 1
		SET @DT2 = GETDATE()

		--PRINT '임시 테이블 데이트 입력 완료' + CONVERT(VARCHAR(20), @DT1,120) + ' / ' + CONVERT(VARCHAR(20), @DT2 - @DT1,120)

		SET @DT1 = GETDATE()



	Fetch next from CusorInterface into 
		@CreateDate, @PONO, @TrimInSeq, @VIN, @CarType, @TotalResult, @STATION_ID, @T01_N01, @T01_N02, @T01_N03, @T02_N01, @T02_N02, @T02_N03, @T03_N01, @T03_N02, @T03_N03, @T04_N01, 
		@T04_N02, @T04_N03, @T05_N01, @T05_N02, @T05_N03, @T06_N01, @T06_N02, @T06_N03, @T07_N01, @T07_N02, @T07_N03, @T08_N01, @T08_N02, @T08_N03, @T09_N01, @T09_N02, @T09_N03, @T10_N01, 
		@T10_N02, @T10_N03, @T11_N01, @T11_N02, @T11_N03, @T12_N01, @T12_N02, @T12_N03, @T13_N01, @T13_N02, @T13_N03, @T14_N01, @T14_N02, @T14_N03, @T15_N01, @T15_N02, @T15_N03, @T16_N01, 
		@T16_N02, @T16_N03, @T17_N01, @T17_N02, @T17_N03, @T18_N01, @T18_N02, @T18_N03, @T19_N01, @T19_N02, @T19_N03, @T20_N01, @T20_N02, @T20_N03, @T21_N01, @T21_N02, @T21_N03, @T22_N01, 
		@T22_N02, @T22_N03, @T23_N01, @T23_N02, @T23_N03, @T24_N01, @T24_N02, @T24_N03, @T25_N01, @T25_N02, @T25_N03
	end  
	close CusorInterface

	deallocate CusorInterface

	
	
	PRINT '데이터 인서트 완료' + CONVERT(VARCHAR(20), @DT1,120) + ' / ' + CONVERT(VARCHAR(20), @DT2 - @DT1,120)
	
	SELECT @TCnt TotalCount, @cnt WorkCount, @TCnt-@cnt RemainQty
	

END
";

			sql.Excute_Query(qry, "");
			
		}


	}
}
