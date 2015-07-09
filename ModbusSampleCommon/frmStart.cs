using System;
using System.Net;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ModbusTCP;

namespace Modbus
{
	public class frmStart : System.Windows.Forms.Form
	{
		private ModbusTCP.Master	MBmaster;
		private TextBox				txtData;
		private Label				labData;
		private byte[]				data;

		private System.Windows.Forms.GroupBox grpData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Button btnReadDisInp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStartAdress;
		private System.Windows.Forms.Button btnReadCoils;
		private System.Windows.Forms.GroupBox grpStart;
		private System.Windows.Forms.GroupBox grpExchange;
		private System.Windows.Forms.Button btnReadHoldReg;
		private System.Windows.Forms.Button btnReadInpReg;
		private System.Windows.Forms.Button btnWriteSingleCoil;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radBits;
		private System.Windows.Forms.RadioButton radBytes;
		private System.Windows.Forms.RadioButton radWord;
		private System.Windows.Forms.Button btnWriteSingleReg;
		private System.Windows.Forms.Button btnWriteMultipleCoils;
        private System.Windows.Forms.Button btnWriteMultipleReg;
        private Label label4;
        private TextBox txtUnit;
		private System.ComponentModel.IContainer components;

		public frmStart()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.grpData = new System.Windows.Forms.GroupBox();
            this.grpStart = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.grpExchange = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnWriteMultipleReg = new System.Windows.Forms.Button();
            this.btnWriteMultipleCoils = new System.Windows.Forms.Button();
            this.btnWriteSingleReg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radWord = new System.Windows.Forms.RadioButton();
            this.radBytes = new System.Windows.Forms.RadioButton();
            this.radBits = new System.Windows.Forms.RadioButton();
            this.btnWriteSingleCoil = new System.Windows.Forms.Button();
            this.btnReadInpReg = new System.Windows.Forms.Button();
            this.btnReadHoldReg = new System.Windows.Forms.Button();
            this.btnReadDisInp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartAdress = new System.Windows.Forms.TextBox();
            this.btnReadCoils = new System.Windows.Forms.Button();
            this.grpStart.SuspendLayout();
            this.grpExchange.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpData.Location = new System.Drawing.Point(7, 194);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(740, 271);
            this.grpData.TabIndex = 9;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            this.grpData.Visible = false;
            // 
            // grpStart
            // 
            this.grpStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStart.Controls.Add(this.label1);
            this.grpStart.Controls.Add(this.btnConnect);
            this.grpStart.Controls.Add(this.txtIP);
            this.grpStart.Location = new System.Drawing.Point(7, 7);
            this.grpStart.Name = "grpStart";
            this.grpStart.Size = new System.Drawing.Size(740, 55);
            this.grpStart.TabIndex = 11;
            this.grpStart.TabStop = false;
            this.grpStart.Text = "Start communication";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(187, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(93, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(87, 20);
            this.txtIP.TabIndex = 5;
            this.txtIP.Text = "192.168.100.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpExchange
            // 
            this.grpExchange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExchange.Controls.Add(this.label4);
            this.grpExchange.Controls.Add(this.txtUnit);
            this.grpExchange.Controls.Add(this.btnWriteMultipleReg);
            this.grpExchange.Controls.Add(this.btnWriteMultipleCoils);
            this.grpExchange.Controls.Add(this.btnWriteSingleReg);
            this.grpExchange.Controls.Add(this.groupBox1);
            this.grpExchange.Controls.Add(this.btnWriteSingleCoil);
            this.grpExchange.Controls.Add(this.btnReadInpReg);
            this.grpExchange.Controls.Add(this.btnReadHoldReg);
            this.grpExchange.Controls.Add(this.btnReadDisInp);
            this.grpExchange.Controls.Add(this.label3);
            this.grpExchange.Controls.Add(this.txtSize);
            this.grpExchange.Controls.Add(this.label2);
            this.grpExchange.Controls.Add(this.txtStartAdress);
            this.grpExchange.Controls.Add(this.btnReadCoils);
            this.grpExchange.Location = new System.Drawing.Point(7, 69);
            this.grpExchange.Name = "grpExchange";
            this.grpExchange.Size = new System.Drawing.Size(740, 118);
            this.grpExchange.TabIndex = 12;
            this.grpExchange.TabStop = false;
            this.grpExchange.Text = "Data exhange";
            this.grpExchange.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "Unit";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(87, 25);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(50, 20);
            this.txtUnit.TabIndex = 24;
            this.txtUnit.Text = "0";
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnWriteMultipleReg
            // 
            this.btnWriteMultipleReg.Location = new System.Drawing.Point(573, 76);
            this.btnWriteMultipleReg.Name = "btnWriteMultipleReg";
            this.btnWriteMultipleReg.Size = new System.Drawing.Size(87, 35);
            this.btnWriteMultipleReg.TabIndex = 23;
            this.btnWriteMultipleReg.Text = "Write multiple register";
            this.btnWriteMultipleReg.Click += new System.EventHandler(this.btnWriteMultipleReg_Click);
            // 
            // btnWriteMultipleCoils
            // 
            this.btnWriteMultipleCoils.Location = new System.Drawing.Point(573, 28);
            this.btnWriteMultipleCoils.Name = "btnWriteMultipleCoils";
            this.btnWriteMultipleCoils.Size = new System.Drawing.Size(87, 34);
            this.btnWriteMultipleCoils.TabIndex = 22;
            this.btnWriteMultipleCoils.Text = "Write multiple coils";
            this.btnWriteMultipleCoils.Click += new System.EventHandler(this.btnWriteMultipleCoils_Click);
            // 
            // btnWriteSingleReg
            // 
            this.btnWriteSingleReg.Location = new System.Drawing.Point(473, 76);
            this.btnWriteSingleReg.Name = "btnWriteSingleReg";
            this.btnWriteSingleReg.Size = new System.Drawing.Size(87, 35);
            this.btnWriteSingleReg.TabIndex = 21;
            this.btnWriteSingleReg.Text = "Write single register";
            this.btnWriteSingleReg.Click += new System.EventHandler(this.btnWriteSingleReg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radWord);
            this.groupBox1.Controls.Add(this.radBytes);
            this.groupBox1.Controls.Add(this.radBits);
            this.groupBox1.Location = new System.Drawing.Point(160, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 90);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show as";
            // 
            // radWord
            // 
            this.radWord.Location = new System.Drawing.Point(13, 62);
            this.radWord.Name = "radWord";
            this.radWord.Size = new System.Drawing.Size(67, 21);
            this.radWord.TabIndex = 2;
            this.radWord.Text = "Word";
            this.radWord.CheckedChanged += new System.EventHandler(this.ShowAs);
            // 
            // radBytes
            // 
            this.radBytes.Location = new System.Drawing.Point(13, 42);
            this.radBytes.Name = "radBytes";
            this.radBytes.Size = new System.Drawing.Size(67, 20);
            this.radBytes.TabIndex = 1;
            this.radBytes.Text = "Bytes";
            this.radBytes.CheckedChanged += new System.EventHandler(this.ShowAs);
            // 
            // radBits
            // 
            this.radBits.Location = new System.Drawing.Point(13, 21);
            this.radBits.Name = "radBits";
            this.radBits.Size = new System.Drawing.Size(67, 21);
            this.radBits.TabIndex = 0;
            this.radBits.Text = "Bits";
            this.radBits.CheckedChanged += new System.EventHandler(this.ShowAs);
            // 
            // btnWriteSingleCoil
            // 
            this.btnWriteSingleCoil.Location = new System.Drawing.Point(473, 28);
            this.btnWriteSingleCoil.Name = "btnWriteSingleCoil";
            this.btnWriteSingleCoil.Size = new System.Drawing.Size(87, 34);
            this.btnWriteSingleCoil.TabIndex = 19;
            this.btnWriteSingleCoil.Text = "Write single coil";
            this.btnWriteSingleCoil.Click += new System.EventHandler(this.btnWriteSingleCoil_Click);
            // 
            // btnReadInpReg
            // 
            this.btnReadInpReg.Location = new System.Drawing.Point(373, 76);
            this.btnReadInpReg.Name = "btnReadInpReg";
            this.btnReadInpReg.Size = new System.Drawing.Size(87, 35);
            this.btnReadInpReg.TabIndex = 18;
            this.btnReadInpReg.Text = "Read input register";
            this.btnReadInpReg.Click += new System.EventHandler(this.btnReadInpReg_Click);
            // 
            // btnReadHoldReg
            // 
            this.btnReadHoldReg.Location = new System.Drawing.Point(373, 28);
            this.btnReadHoldReg.Name = "btnReadHoldReg";
            this.btnReadHoldReg.Size = new System.Drawing.Size(87, 34);
            this.btnReadHoldReg.TabIndex = 17;
            this.btnReadHoldReg.Text = "Read holding register";
            this.btnReadHoldReg.Click += new System.EventHandler(this.btnReadHoldReg_Click);
            // 
            // btnReadDisInp
            // 
            this.btnReadDisInp.Location = new System.Drawing.Point(273, 76);
            this.btnReadDisInp.Name = "btnReadDisInp";
            this.btnReadDisInp.Size = new System.Drawing.Size(87, 35);
            this.btnReadDisInp.TabIndex = 16;
            this.btnReadDisInp.Text = "Read discrete inputs";
            this.btnReadDisInp.Click += new System.EventHandler(this.btnReadDisInp_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(87, 78);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(50, 20);
            this.txtSize.TabIndex = 14;
            this.txtSize.Text = "32";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Adress";
            // 
            // txtStartAdress
            // 
            this.txtStartAdress.Location = new System.Drawing.Point(87, 51);
            this.txtStartAdress.Name = "txtStartAdress";
            this.txtStartAdress.Size = new System.Drawing.Size(50, 20);
            this.txtStartAdress.TabIndex = 12;
            this.txtStartAdress.Text = "0";
            this.txtStartAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReadCoils
            // 
            this.btnReadCoils.Location = new System.Drawing.Point(273, 28);
            this.btnReadCoils.Name = "btnReadCoils";
            this.btnReadCoils.Size = new System.Drawing.Size(87, 34);
            this.btnReadCoils.TabIndex = 11;
            this.btnReadCoils.Text = "Read coils";
            this.btnReadCoils.CursorChanged += new System.EventHandler(this.btnReadCoils_Click);
            this.btnReadCoils.Click += new System.EventHandler(this.btnReadCoils_Click);
            // 
            // frmStart
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(753, 471);
            this.Controls.Add(this.grpExchange);
            this.Controls.Add(this.grpStart);
            this.Controls.Add(this.grpData);
            this.Name = "frmStart";
            this.Text = "ModbusTCP Tester V1.1";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmStart_Closing);
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.SizeChanged += new System.EventHandler(this.frmStart_Resize);
            this.grpStart.ResumeLayout(false);
            this.grpStart.PerformLayout();
            this.grpExchange.ResumeLayout(false);
            this.grpExchange.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmStart());
		}


		// ------------------------------------------------------------------------
		// Programm start
		// ------------------------------------------------------------------------
		private void frmStart_Load(object sender, System.EventArgs e)
		{
			// Set standard format byte, make some textboxes
			radBytes.Checked = true;
			data = new byte[0];
			ResizeData();
		}

		// ------------------------------------------------------------------------
		// Programm stop
		// ------------------------------------------------------------------------
		private void frmStart_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(MBmaster != null) 
			{
				MBmaster.Dispose();
				MBmaster = null;
			}	
			Application.Exit();
		}
		
		// ------------------------------------------------------------------------
		// Button connect
		// ------------------------------------------------------------------------
		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Create new modbus master and add event functions
				MBmaster = new Master(txtIP.Text, 502);
				MBmaster.OnResponseData += new ModbusTCP.Master.ResponseData(MBmaster_OnResponseData);
				MBmaster.OnException	+= new ModbusTCP.Master.ExceptionData(MBmaster_OnException);
				// Show additional fields, enable watchdog
				grpExchange.Visible		= true;
				grpData.Visible			= true;	
			}
			catch(SystemException error)
			{
				MessageBox.Show(error.Message);
			}
		}

		// ------------------------------------------------------------------------
		// Button read coils
		// ------------------------------------------------------------------------
		private void btnReadCoils_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 1;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

            MBmaster.ReadCoils(ID, unit, StartAddress, Length);
		}

		// ------------------------------------------------------------------------
		// Button read discrete inputs
		// ------------------------------------------------------------------------
		private void btnReadDisInp_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 2;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

			MBmaster.ReadDiscreteInputs(ID, unit, StartAddress, Length);	
		}

		// ------------------------------------------------------------------------
		// Button read holding register
		// ------------------------------------------------------------------------
		private void btnReadHoldReg_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 3;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

			MBmaster.ReadHoldingRegister(ID, unit, StartAddress, Length);		
		}

		// ------------------------------------------------------------------------
		// Button read holding register
		// ------------------------------------------------------------------------
		private void btnReadInpReg_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 4;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();
			byte Length			= Convert.ToByte(txtSize.Text);

			MBmaster.ReadInputRegister(ID, unit, StartAddress, Length);			
		}

		// ------------------------------------------------------------------------
		// Button write single coil
		// ------------------------------------------------------------------------
		private void btnWriteSingleCoil_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 5;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();

			data			= GetData(1);
			txtSize.Text	= "1";

			MBmaster.WriteSingleCoils(ID, unit, StartAddress, Convert.ToBoolean(data[0]));
		}

		// ------------------------------------------------------------------------
		// Button write multiple coils
		// ------------------------------------------------------------------------	
		private void btnWriteMultipleCoils_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 6;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();

			data = GetData(Convert.ToByte(txtSize.Text));
			MBmaster.WriteMultipleCoils(ID, unit, StartAddress, Convert.ToByte(txtSize.Text), data);		
		}

		// ------------------------------------------------------------------------
		// Button write single register
		// ------------------------------------------------------------------------
		private void btnWriteSingleReg_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 7;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();

			data			= GetData(2);
			txtSize.Text	= "1";
			txtData.Text	= data[0].ToString();

			MBmaster.WriteSingleRegister(ID, unit, StartAddress, data);
		}
		
		// ------------------------------------------------------------------------
		// Button write multiple register
		// ------------------------------------------------------------------------	
		private void btnWriteMultipleReg_Click(object sender, System.EventArgs e)
		{
			ushort ID			= 8;
            byte unit           = Convert.ToByte(txtUnit.Text);
            ushort StartAddress = ReadStartAdr();

			data = GetData(Convert.ToByte(txtSize.Text));
			MBmaster.WriteMultipleRegister(ID, unit, StartAddress, data);		
		}

		// ------------------------------------------------------------------------
		// Event for response data
		// ------------------------------------------------------------------------
		private void MBmaster_OnResponseData(ushort ID, byte unit, byte function, byte[] values)
		{
            // ------------------------------------------------------------------
            // Seperate calling threads
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Master.ResponseData(MBmaster_OnResponseData), new object[] { ID, unit, function, values });
                return;
            }

			// ------------------------------------------------------------------------
			// Identify requested data
			switch(ID)
			{
				case 1:
					grpData.Text = "Read coils";
					data = values;
					ShowAs(null, null);
				break;
				case 2:
					grpData.Text = "Read discrete inputs";
					data = values;
					ShowAs(null, null);
				break;
				case 3:
					grpData.Text = "Read holding register";
					data = values;
					ShowAs(null, null);
				break;
				case 4:
					grpData.Text = "Read input register";
					data = values;
					ShowAs(null, null);
				break;
				case 5:
					grpData.Text = "Write single coil";
				break;
				case 6:
					grpData.Text = "Write multiple coils";
				break;
				case 7:
					grpData.Text = "Write single register";
				break;
				case 8:
					grpData.Text = "Write multiple register";
				break;
			}	
		}

		// ------------------------------------------------------------------------
		// Modbus TCP slave exception
		// ------------------------------------------------------------------------
		private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
		{
			string exc = "Modbus says error: ";
			switch(exception)
			{
				case Master.excIllegalFunction: exc += "Illegal function!"; break;
				case Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
				case Master.excIllegalDataVal: exc += "Illegal data value!"; break;
				case Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
				case Master.excAck: exc += "Acknoledge!"; break;
				case Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
				case Master.excExceptionTimeout: exc += "Slave timed out!"; break;
				case Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
				case Master.excExceptionNotConnected: exc += "Not connected!"; break;
			}

			MessageBox.Show(exc, "Modbus slave exception");
		}

		// ------------------------------------------------------------------------
		// Generate new number of text boxes
		// ------------------------------------------------------------------------
		private void ResizeData()
		{
			// Create as many textboxes as fit into window
			grpData.Controls.Clear();
			int x = 0;
			int y = 10;
			int z = 20;
			while(y < grpData.Size.Width - 100)
			{
				labData				= new Label();
				grpData.Controls.Add(labData);
				labData.Size		= new System.Drawing.Size(30, 20);
				labData.Location	= new System.Drawing.Point(y, z);
				labData.Text		= Convert.ToString(x + 1);

				txtData				= new TextBox();
				grpData.Controls.Add(txtData);
				txtData.Size		= new System.Drawing.Size(50, 20);
				txtData.Location	= new System.Drawing.Point(y + 30, z);
				txtData.TextAlign	= System.Windows.Forms.HorizontalAlignment.Right;
				txtData.Tag			= x;

				x++;
				z = z + txtData.Size.Height + 5;
				if(z > grpData.Size.Height - 40) 
				{
					y = y + 100;
					z = 20;
				}
			}
		}

		// ------------------------------------------------------------------------
		// Resize form elements
		// ------------------------------------------------------------------------
		private void frmStart_Resize(object sender, System.EventArgs e)
		{
			if(grpData.Visible == true) ResizeData();
		}

		// ------------------------------------------------------------------------
		// Read start address
		// ------------------------------------------------------------------------
		private ushort ReadStartAdr()
		{
			// Convert hex numbers into decimal
			if(txtStartAdress.Text.IndexOf("0x", 0, txtStartAdress.Text.Length) == 0) 
			{
				string str = txtStartAdress.Text.Replace("0x", "");
				ushort hex = Convert.ToUInt16(str, 16);
				return hex;
			}
			else 
			{
				return Convert.ToUInt16(txtStartAdress.Text);
			}
		}

		// ------------------------------------------------------------------------
		// Read values from textboxes
		// ------------------------------------------------------------------------
		private byte[] GetData(int num)
		{
			bool[] bits	= new bool[num];
			byte[] data	= new Byte[num];
			int[]  word	= new int[num];

			// ------------------------------------------------------------------------
			// Convert data from text boxes
			foreach(Control ctrl in grpData.Controls)
			{
				if (ctrl is TextBox)
				{
					int x = Convert.ToInt16(ctrl.Tag);
					if(radBits.Checked)
					{
						if((x <= bits.GetUpperBound(0)) && (ctrl.Text != "")) bits[x] = Convert.ToBoolean(Convert.ToByte(ctrl.Text));
						else break;
					}
					if(radBytes.Checked)
					{
						if((x <= data.GetUpperBound(0)) && (ctrl.Text != "")) data[x] = Convert.ToByte(ctrl.Text);
						else break;
					}
					if(radWord.Checked)
					{
                        if ((x <= data.GetUpperBound(0)) && (ctrl.Text != ""))
                        {
                            try { word[x] = Convert.ToInt16(ctrl.Text); }
                            catch(SystemException) { word[x] = Convert.ToUInt16(ctrl.Text);};
                        }
                        else break;
					}
				}
			}
			if(radBits.Checked)
			{
				int numBytes		= (byte)(num / 8 + (num % 8 > 0 ? 1 : 0));
				data				= new Byte[numBytes];
				BitArray bitArray	= new BitArray(bits);
				bitArray.CopyTo(data, 0);
			}
			if(radWord.Checked)
			{
				data = new Byte[num*2];
				for(int x=0;x<num;x++)
				{
					byte[] dat = BitConverter.GetBytes((short) IPAddress.HostToNetworkOrder((short) word[x]));
					data[x*2]	= dat[0];
					data[x*2+1] = dat[1];
				}
			}
			return data;
		}

		// ------------------------------------------------------------------------
		// Show values in selected way
		// ------------------------------------------------------------------------
		private void ShowAs(object sender, System.EventArgs e)
		{
			RadioButton rad;
			if(sender is RadioButton)	
			{
				rad = (RadioButton) sender;
				if(rad.Checked == false) return;
			}

			bool[]	bits = new bool[1];
			int[]	word = new int[1];

			// Convert data to selected data type
			if(radBits.Checked == true)
			{
				BitArray bitArray = new BitArray(data);
				bits = new bool[bitArray.Count];
				bitArray.CopyTo(bits, 0);
			}
			if(radWord.Checked == true)
			{
				if(data.Length < 2) return;
				word = new int[data.Length/2];
				for(int x=0;x<data.Length;x=x+2)
				{
					word[x/2] = data[x] * 256 + data[x+1];
				}
			}

			// ------------------------------------------------------------------------
			// Put new data into text boxes
			foreach(Control ctrl in grpData.Controls)
			{
				if (ctrl is TextBox)
				{
					int x = Convert.ToInt16(ctrl.Tag);
					if(radBits.Checked)
					{
						if(x <= bits.GetUpperBound(0)) 
						{
							ctrl.Text = Convert.ToByte(bits[x]).ToString();
							ctrl.Visible = true;
						}
						else ctrl.Text = "";
					}
					if(radBytes.Checked)
					{
						if(x <= data.GetUpperBound(0)) 
						{
							ctrl.Text = data[x].ToString();
							ctrl.Visible = true;
						}
						else ctrl.Text = "";
					}
					if(radWord.Checked)
					{
						if(x <= word.GetUpperBound(0)) 
						{
							ctrl.Text = word[x].ToString();
							ctrl.Visible = true;
						}
						else ctrl.Text = "";
					}
				}
			}
		}

	}
}
