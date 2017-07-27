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
 CONSTRAINT [PK_TResult] PRIMARY KEY CLUSTERED 
(
	[CreateDate] ASC,
	[STATION_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


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


	}
}
