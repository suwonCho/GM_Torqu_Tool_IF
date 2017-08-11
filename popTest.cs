using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Function;
using Function.form;
using System.Threading;

namespace GM_Torqu_Tool_IF
{
	public partial class popTest : Function.form.subBaseForm
	{
		/// <summary>
		/// 조건 차종 배열
		/// </summary>
		string[] cond_cartype = new string[] { "", "G30", "T30" };

		/// <summary>
		/// 조건 결과 배열
		/// </summary>
		string[] cond_result = new string[] { "", "OK", "NG" };
			

		bool isRun = false;

		Thread thWork = null;

		int iInterval = 1000;
		int iWorkCnt = 0;
		bool bWorkCancel = false;

		PLCComm.PLCComm _opc;

		
		
		public popTest(PLCComm.PLCComm opc)
		{
			InitializeComponent();

			_opc = opc;

			
		}

		private void popTest_Load(object sender, EventArgs e)
		{
			inpSeq.Value = vari.iTestSeq.ToString();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			if(isRun)
			{   //작업 취소
				bWorkCancel = true;

				Function.form.control.Invoke_Control_SetProperty(inpWorkCnt, "Value", $"{iWorkCnt}");
				Function.form.control.Invoke_Control_Enabled(inpInterval, true);
				Function.form.control.Invoke_Control_Enabled(inpWorkCnt, true);
				Function.form.control.Invoke_Control_Enabled(inpSeq, true);

				Function.form.control.Invoke_Control_Text(btnRun, "수 행");

				vari.PLC_Setting_Save();

				isRun = false;
			}
			else
			{   //작업시작
				iInterval = Fnc.obj2int(inpInterval.Text);
				vari.iTestSeq = Fnc.obj2int(inpSeq.Text);
				iWorkCnt = Fnc.obj2int(inpWorkCnt.Text);

				inpInterval.Enabled = false;
				inpWorkCnt.Enabled = false;
				inpSeq.Enabled = false;

				bWorkCancel = false;

				thWork = new Thread(new ThreadStart(Work));
				thWork.IsBackground = true;
				thWork.Start();
                
				btnRun.Text = "취소";
				isRun = true;

			}
		}

		private void Work()
		{
			try
			{
				int tgr_id = 0;
				int ack_id = 0;
				string data;
				int idx;
				int ii = 0;
				char head;
				int cnt = 0;

				Random rnd = new Random();

				//plc 값 초기화
				_opc.WriteOrder(vari.plc.Add_Ack, 0);
				_opc.WriteOrder(vari.plc.Add_Trigger, 0);
				_opc.WriteOrder(vari.plc.Add_Data, 0);

				while (true)
				{

					tgr_id = _opc.GetValueInt(vari.plc.Add_Trigger);
					ack_id = _opc.GetValueInt(vari.plc.Add_Ack);

					

					//같으면 다음 데이터 보낸다.
					if (tgr_id == ack_id)
					{
						tgr_id++;						
						vari.iTestSeq++;
						cnt++;

						if (cnt > 99999) cnt = 1;
						if (tgr_id > 9999) tgr_id = 1;
						if (vari.iTestSeq > 9999) vari.iTestSeq = 1;

						//data를 만든다.
						data = $"A{cnt:D5}";
						data += $"{vari.iTestSeq:D4}";
						data += $"VIN{vari.iTestSeq:D14} ";

						idx = rnd.Next(1, 3);
						data += cond_cartype[idx];

						idx = rnd.Next(0, 10);
						data += idx == 1 ? cond_result[2] : cond_result[1];

						ii++;

						if (ii > 999) ii = 1;

						for(int x = 0; x < 25;x++)
						{
							head = Convert.ToChar(65 + x);

							for(int y=0;y < 3; y++)
							{
								switch(y)
								{
									case 0:
										data += $"{head}{ii:D3}";
										break;

									case 1:
										data += $"{ii:D3}{head}";
										break;

									default:
										idx = rnd.Next(0, 10);
										data += idx == 1 ? cond_result[2] : cond_result[1];
										break;
								}
							}
						}


						_opc.WriteOrder(vari.plc.Add_Data, data);
						_opc.WriteOrder(vari.plc.Add_Trigger, tgr_id);

						
						Function.form.control.Invoke_Control_SetProperty(inpWorkCnt, "Value", iWorkCnt.ToString());
						Function.form.control.Invoke_Control_SetProperty(inpSeq, "Value", $"{vari.iTestSeq:D4}");
						Function.form.control.Invoke_Control_SetProperty(inpWorkCnt, "Value", $"{cnt} / {iWorkCnt}");

					}

					Function.form.control.Invoke_Control_SetProperty(inpID, "Value", $"{tgr_id:D4} / {ack_id:D4}");	

					

					if(iWorkCnt > 0 && iWorkCnt <= cnt)
					{
						btnRun_Click(null, null);
						break;
					}


					if (bWorkCancel) break;

					Application.DoEvents();

					Thread.Sleep(iInterval);
				}

			}
			catch
			{

			}
		}

		private void popTest_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(isRun)
			{
				Function.clsFunction.ShowMsg("작업중", "작업중", frmMessage.enMessageType.OK);
				e.Cancel = true;
			}
		}
	}
}
