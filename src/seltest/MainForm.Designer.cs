/*
 * Gemaakt met SharpDevelop.
 * Gebruiker: freek
 * Datum: 1-3-2012
 * Tijd: 16:40
 * 
 * Dit sjabloon wijzigen: Extra | Opties |Coderen | Standaard kop bewerken.
 */
namespace seltest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbLocTestform = new System.Windows.Forms.TextBox();
			this.lTestsuite = new System.Windows.Forms.Label();
			this.cbFirefox = new System.Windows.Forms.CheckBox();
			this.cbIEhta = new System.Windows.Forms.CheckBox();
			this.cbGooglechrome = new System.Windows.Forms.CheckBox();
			this.cbSafariproxy = new System.Windows.Forms.CheckBox();
			this.lLoclog = new System.Windows.Forms.Label();
			this.tbLocLog = new System.Windows.Forms.TextBox();
			this.bSelectTestform = new System.Windows.Forms.Button();
			this.bSelectLoglocation = new System.Windows.Forms.Button();
			this.gbTestfile = new System.Windows.Forms.GroupBox();
			this.bSelectUserextension = new System.Windows.Forms.Button();
			this.tbUserextension = new System.Windows.Forms.TextBox();
			this.lUserextension = new System.Windows.Forms.Label();
			this.tbLooptimes = new System.Windows.Forms.TextBox();
			this.lLoop = new System.Windows.Forms.Label();
			this.cbOpera = new System.Windows.Forms.CheckBox();
			this.bRuntest = new System.Windows.Forms.Button();
			this.bReset = new System.Windows.Forms.Button();
			this.tbLocSeleniumBinary = new System.Windows.Forms.TextBox();
			this.lSeleniumbinary = new System.Windows.Forms.Label();
			this.gbAppsettings = new System.Windows.Forms.GroupBox();
			this.lPortnr = new System.Windows.Forms.Label();
			this.tbPortnr = new System.Windows.Forms.TextBox();
			this.lOntop = new System.Windows.Forms.Label();
			this.cbWindowontop = new System.Windows.Forms.CheckBox();
			this.bLocSeleniumbinary = new System.Windows.Forms.Button();
			this.bShowlogs = new System.Windows.Forms.Button();
			this.tbStatusbox = new System.Windows.Forms.TextBox();
			this.gbStatusbox = new System.Windows.Forms.GroupBox();
			this.bClearStatus = new System.Windows.Forms.Button();
			this.gbTest = new System.Windows.Forms.GroupBox();
			this.bKillTest = new System.Windows.Forms.Button();
			this.gbTestbrowsers = new System.Windows.Forms.GroupBox();
			this.cbSafari = new System.Windows.Forms.CheckBox();
			this.cbFirefoxproxy = new System.Windows.Forms.CheckBox();
			this.cbFirefoxPi = new System.Windows.Forms.CheckBox();
			this.cbIEpi = new System.Windows.Forms.CheckBox();
			this.cbIE = new System.Windows.Forms.CheckBox();
			this.cbFirefoxchrome = new System.Windows.Forms.CheckBox();
			this.tbOtherbrowser = new System.Windows.Forms.TextBox();
			this.cbOtherbrowser = new System.Windows.Forms.CheckBox();
			this.lCreditCreator = new System.Windows.Forms.Label();
			this.lCreditSelenium = new System.Windows.Forms.Label();
			this.lAboutVersionnr = new System.Windows.Forms.Label();
			this.lVersion = new System.Windows.Forms.Label();
			this.gbCredits = new System.Windows.Forms.GroupBox();
			this.gbTestfile.SuspendLayout();
			this.gbAppsettings.SuspendLayout();
			this.gbStatusbox.SuspendLayout();
			this.gbTest.SuspendLayout();
			this.gbTestbrowsers.SuspendLayout();
			this.gbCredits.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbLocTestform
			// 
			this.tbLocTestform.BackColor = System.Drawing.Color.White;
			this.tbLocTestform.Enabled = false;
			this.tbLocTestform.Location = new System.Drawing.Point(94, 18);
			this.tbLocTestform.Name = "tbLocTestform";
			this.tbLocTestform.ReadOnly = true;
			this.tbLocTestform.Size = new System.Drawing.Size(268, 20);
			this.tbLocTestform.TabIndex = 1;
			// 
			// lTestsuite
			// 
			this.lTestsuite.Location = new System.Drawing.Point(35, 23);
			this.lTestsuite.Name = "lTestsuite";
			this.lTestsuite.Size = new System.Drawing.Size(54, 12);
			this.lTestsuite.TabIndex = 3;
			this.lTestsuite.Text = "Testsuite";
			// 
			// cbFirefox
			// 
			this.cbFirefox.Enabled = false;
			this.cbFirefox.Location = new System.Drawing.Point(8, 70);
			this.cbFirefox.Name = "cbFirefox";
			this.cbFirefox.Size = new System.Drawing.Size(97, 24);
			this.cbFirefox.TabIndex = 4;
			this.cbFirefox.Tag = "firefox";
			this.cbFirefox.Text = "Mozillla Firefox";
			this.cbFirefox.UseVisualStyleBackColor = true;
			// 
			// cbIEhta
			// 
			this.cbIEhta.Enabled = false;
			this.cbIEhta.Location = new System.Drawing.Point(8, 55);
			this.cbIEhta.Name = "cbIEhta";
			this.cbIEhta.Size = new System.Drawing.Size(239, 18);
			this.cbIEhta.TabIndex = 5;
			this.cbIEhta.Tag = "iehta";
			this.cbIEhta.Text = "Internet Explorer (elevated security privileges)";
			this.cbIEhta.UseVisualStyleBackColor = true;
			// 
			// cbGooglechrome
			// 
			this.cbGooglechrome.Enabled = false;
			this.cbGooglechrome.Location = new System.Drawing.Point(250, 11);
			this.cbGooglechrome.Name = "cbGooglechrome";
			this.cbGooglechrome.Size = new System.Drawing.Size(104, 24);
			this.cbGooglechrome.TabIndex = 6;
			this.cbGooglechrome.Tag = "googlechrome";
			this.cbGooglechrome.Text = "Google Chrome";
			this.cbGooglechrome.UseVisualStyleBackColor = true;
			// 
			// cbSafariproxy
			// 
			this.cbSafariproxy.Enabled = false;
			this.cbSafariproxy.Location = new System.Drawing.Point(250, 49);
			this.cbSafariproxy.Name = "cbSafariproxy";
			this.cbSafariproxy.Size = new System.Drawing.Size(119, 24);
			this.cbSafariproxy.TabIndex = 7;
			this.cbSafariproxy.Tag = "safariproxy";
			this.cbSafariproxy.Text = "Apple Safari (proxy)";
			this.cbSafariproxy.UseVisualStyleBackColor = true;
			// 
			// lLoclog
			// 
			this.lLoclog.Location = new System.Drawing.Point(24, 48);
			this.lLoclog.Name = "lLoclog";
			this.lLoclog.Size = new System.Drawing.Size(66, 19);
			this.lLoclog.TabIndex = 11;
			this.lLoclog.Text = "Log location";
			// 
			// tbLocLog
			// 
			this.tbLocLog.BackColor = System.Drawing.Color.White;
			this.tbLocLog.Location = new System.Drawing.Point(94, 47);
			this.tbLocLog.Name = "tbLocLog";
			this.tbLocLog.ReadOnly = true;
			this.tbLocLog.Size = new System.Drawing.Size(269, 20);
			this.tbLocLog.TabIndex = 10;
			// 
			// bSelectTestform
			// 
			this.bSelectTestform.Location = new System.Drawing.Point(368, 17);
			this.bSelectTestform.Name = "bSelectTestform";
			this.bSelectTestform.Size = new System.Drawing.Size(33, 21);
			this.bSelectTestform.TabIndex = 12;
			this.bSelectTestform.Text = "...";
			this.bSelectTestform.UseVisualStyleBackColor = true;
			this.bSelectTestform.Click += new System.EventHandler(this.BSelectTestformClick);
			// 
			// bSelectLoglocation
			// 
			this.bSelectLoglocation.Location = new System.Drawing.Point(369, 47);
			this.bSelectLoglocation.Name = "bSelectLoglocation";
			this.bSelectLoglocation.Size = new System.Drawing.Size(33, 23);
			this.bSelectLoglocation.TabIndex = 13;
			this.bSelectLoglocation.Text = "...";
			this.bSelectLoglocation.UseVisualStyleBackColor = true;
			this.bSelectLoglocation.Click += new System.EventHandler(this.BSelectLoglocationClick);
			// 
			// gbTestfile
			// 
			this.gbTestfile.Controls.Add(this.lTestsuite);
			this.gbTestfile.Controls.Add(this.bSelectUserextension);
			this.gbTestfile.Controls.Add(this.tbLocTestform);
			this.gbTestfile.Controls.Add(this.tbUserextension);
			this.gbTestfile.Controls.Add(this.bSelectTestform);
			this.gbTestfile.Controls.Add(this.lUserextension);
			this.gbTestfile.Controls.Add(this.tbLooptimes);
			this.gbTestfile.Controls.Add(this.lLoop);
			this.gbTestfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTestfile.Location = new System.Drawing.Point(7, 110);
			this.gbTestfile.Name = "gbTestfile";
			this.gbTestfile.Size = new System.Drawing.Size(412, 98);
			this.gbTestfile.TabIndex = 26;
			this.gbTestfile.TabStop = false;
			this.gbTestfile.Text = "Test Settings";
			// 
			// bSelectUserextension
			// 
			this.bSelectUserextension.Location = new System.Drawing.Point(368, 41);
			this.bSelectUserextension.Name = "bSelectUserextension";
			this.bSelectUserextension.Size = new System.Drawing.Size(33, 22);
			this.bSelectUserextension.TabIndex = 16;
			this.bSelectUserextension.Text = "...";
			this.bSelectUserextension.UseVisualStyleBackColor = true;
			this.bSelectUserextension.Click += new System.EventHandler(this.BSelectUserextensionClick);
			// 
			// tbUserextension
			// 
			this.tbUserextension.BackColor = System.Drawing.Color.White;
			this.tbUserextension.Location = new System.Drawing.Point(94, 43);
			this.tbUserextension.Name = "tbUserextension";
			this.tbUserextension.ReadOnly = true;
			this.tbUserextension.Size = new System.Drawing.Size(268, 20);
			this.tbUserextension.TabIndex = 15;
			// 
			// lUserextension
			// 
			this.lUserextension.Location = new System.Drawing.Point(6, 46);
			this.lUserextension.Name = "lUserextension";
			this.lUserextension.Size = new System.Drawing.Size(84, 19);
			this.lUserextension.TabIndex = 14;
			this.lUserextension.Text = "User Extension";
			// 
			// tbLooptimes
			// 
			this.tbLooptimes.Enabled = false;
			this.tbLooptimes.Location = new System.Drawing.Point(95, 69);
			this.tbLooptimes.Name = "tbLooptimes";
			this.tbLooptimes.Size = new System.Drawing.Size(28, 20);
			this.tbLooptimes.TabIndex = 26;
			this.tbLooptimes.Text = "1";
			// 
			// lLoop
			// 
			this.lLoop.Location = new System.Drawing.Point(22, 70);
			this.lLoop.Name = "lLoop";
			this.lLoop.Size = new System.Drawing.Size(63, 19);
			this.lLoop.TabIndex = 27;
			this.lLoop.Text = "Repeat test";
			// 
			// cbOpera
			// 
			this.cbOpera.Enabled = false;
			this.cbOpera.Location = new System.Drawing.Point(250, 75);
			this.cbOpera.Name = "cbOpera";
			this.cbOpera.Size = new System.Drawing.Size(64, 19);
			this.cbOpera.TabIndex = 24;
			this.cbOpera.Tag = "opera";
			this.cbOpera.Text = "Opera";
			this.cbOpera.UseVisualStyleBackColor = true;
			// 
			// bRuntest
			// 
			this.bRuntest.Enabled = false;
			this.bRuntest.Location = new System.Drawing.Point(9, 15);
			this.bRuntest.Name = "bRuntest";
			this.bRuntest.Size = new System.Drawing.Size(97, 23);
			this.bRuntest.TabIndex = 23;
			this.bRuntest.Text = "Run Test";
			this.bRuntest.UseVisualStyleBackColor = true;
			this.bRuntest.Click += new System.EventHandler(this.bRuntestClick);
			// 
			// bReset
			// 
			this.bReset.Location = new System.Drawing.Point(9, 73);
			this.bReset.Name = "bReset";
			this.bReset.Size = new System.Drawing.Size(97, 23);
			this.bReset.TabIndex = 25;
			this.bReset.Text = "Reset Settings";
			this.bReset.UseVisualStyleBackColor = true;
			this.bReset.Click += new System.EventHandler(this.bResetClick);
			// 
			// tbLocSeleniumBinary
			// 
			this.tbLocSeleniumBinary.BackColor = System.Drawing.Color.White;
			this.tbLocSeleniumBinary.Location = new System.Drawing.Point(94, 22);
			this.tbLocSeleniumBinary.Name = "tbLocSeleniumBinary";
			this.tbLocSeleniumBinary.ReadOnly = true;
			this.tbLocSeleniumBinary.Size = new System.Drawing.Size(269, 20);
			this.tbLocSeleniumBinary.TabIndex = 18;
			// 
			// lSeleniumbinary
			// 
			this.lSeleniumbinary.Location = new System.Drawing.Point(14, 24);
			this.lSeleniumbinary.Name = "lSeleniumbinary";
			this.lSeleniumbinary.Size = new System.Drawing.Size(84, 21);
			this.lSeleniumbinary.TabIndex = 19;
			this.lSeleniumbinary.Text = "Selenium Binary";
			// 
			// gbAppsettings
			// 
			this.gbAppsettings.Controls.Add(this.lPortnr);
			this.gbAppsettings.Controls.Add(this.tbPortnr);
			this.gbAppsettings.Controls.Add(this.lOntop);
			this.gbAppsettings.Controls.Add(this.cbWindowontop);
			this.gbAppsettings.Controls.Add(this.bLocSeleniumbinary);
			this.gbAppsettings.Controls.Add(this.tbLocSeleniumBinary);
			this.gbAppsettings.Controls.Add(this.bSelectLoglocation);
			this.gbAppsettings.Controls.Add(this.lSeleniumbinary);
			this.gbAppsettings.Controls.Add(this.lLoclog);
			this.gbAppsettings.Controls.Add(this.tbLocLog);
			this.gbAppsettings.Location = new System.Drawing.Point(6, 2);
			this.gbAppsettings.Name = "gbAppsettings";
			this.gbAppsettings.Size = new System.Drawing.Size(413, 102);
			this.gbAppsettings.TabIndex = 21;
			this.gbAppsettings.TabStop = false;
			this.gbAppsettings.Text = "Application Settings";
			// 
			// lPortnr
			// 
			this.lPortnr.Location = new System.Drawing.Point(59, 75);
			this.lPortnr.Name = "lPortnr";
			this.lPortnr.Size = new System.Drawing.Size(31, 19);
			this.lPortnr.TabIndex = 24;
			this.lPortnr.Text = "Port";
			// 
			// tbPortnr
			// 
			this.tbPortnr.Location = new System.Drawing.Point(94, 73);
			this.tbPortnr.Name = "tbPortnr";
			this.tbPortnr.Size = new System.Drawing.Size(37, 20);
			this.tbPortnr.TabIndex = 23;
			this.tbPortnr.Text = "4444";
			// 
			// lOntop
			// 
			this.lOntop.Location = new System.Drawing.Point(138, 74);
			this.lOntop.Name = "lOntop";
			this.lOntop.Size = new System.Drawing.Size(83, 19);
			this.lOntop.TabIndex = 22;
			this.lOntop.Text = "Window on top";
			// 
			// cbWindowontop
			// 
			this.cbWindowontop.Enabled = false;
			this.cbWindowontop.Location = new System.Drawing.Point(222, 71);
			this.cbWindowontop.Name = "cbWindowontop";
			this.cbWindowontop.Size = new System.Drawing.Size(16, 24);
			this.cbWindowontop.TabIndex = 21;
			this.cbWindowontop.UseVisualStyleBackColor = true;
			// 
			// bLocSeleniumbinary
			// 
			this.bLocSeleniumbinary.Location = new System.Drawing.Point(369, 22);
			this.bLocSeleniumbinary.Name = "bLocSeleniumbinary";
			this.bLocSeleniumbinary.Size = new System.Drawing.Size(33, 23);
			this.bLocSeleniumbinary.TabIndex = 20;
			this.bLocSeleniumbinary.Text = "...";
			this.bLocSeleniumbinary.UseVisualStyleBackColor = true;
			this.bLocSeleniumbinary.Click += new System.EventHandler(this.BLocSeleniumbinaryClick);
			// 
			// bShowlogs
			// 
			this.bShowlogs.Location = new System.Drawing.Point(8, 131);
			this.bShowlogs.Name = "bShowlogs";
			this.bShowlogs.Size = new System.Drawing.Size(97, 23);
			this.bShowlogs.TabIndex = 29;
			this.bShowlogs.Text = "Show Logs";
			this.bShowlogs.UseVisualStyleBackColor = true;
			this.bShowlogs.Click += new System.EventHandler(this.BShowlogsClick);
			// 
			// tbStatusbox
			// 
			this.tbStatusbox.BackColor = System.Drawing.Color.White;
			this.tbStatusbox.ForeColor = System.Drawing.Color.Black;
			this.tbStatusbox.Location = new System.Drawing.Point(9, 20);
			this.tbStatusbox.Multiline = true;
			this.tbStatusbox.Name = "tbStatusbox";
			this.tbStatusbox.ReadOnly = true;
			this.tbStatusbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbStatusbox.Size = new System.Drawing.Size(392, 134);
			this.tbStatusbox.TabIndex = 27;
			this.tbStatusbox.WordWrap = false;
			// 
			// gbStatusbox
			// 
			this.gbStatusbox.Controls.Add(this.tbStatusbox);
			this.gbStatusbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbStatusbox.Location = new System.Drawing.Point(6, 214);
			this.gbStatusbox.Name = "gbStatusbox";
			this.gbStatusbox.Size = new System.Drawing.Size(412, 165);
			this.gbStatusbox.TabIndex = 28;
			this.gbStatusbox.TabStop = false;
			this.gbStatusbox.Text = "Status";
			// 
			// bClearStatus
			// 
			this.bClearStatus.Enabled = false;
			this.bClearStatus.Location = new System.Drawing.Point(8, 102);
			this.bClearStatus.Name = "bClearStatus";
			this.bClearStatus.Size = new System.Drawing.Size(98, 23);
			this.bClearStatus.TabIndex = 28;
			this.bClearStatus.Text = "Clear Statusbox";
			this.bClearStatus.UseVisualStyleBackColor = true;
			this.bClearStatus.Click += new System.EventHandler(this.BClearStatusClick);
			// 
			// gbTest
			// 
			this.gbTest.Controls.Add(this.bShowlogs);
			this.gbTest.Controls.Add(this.bKillTest);
			this.gbTest.Controls.Add(this.bClearStatus);
			this.gbTest.Controls.Add(this.bReset);
			this.gbTest.Controls.Add(this.bRuntest);
			this.gbTest.Location = new System.Drawing.Point(424, 215);
			this.gbTest.Name = "gbTest";
			this.gbTest.Size = new System.Drawing.Size(112, 165);
			this.gbTest.TabIndex = 31;
			this.gbTest.TabStop = false;
			this.gbTest.Text = "Test";
			// 
			// bKillTest
			// 
			this.bKillTest.Enabled = false;
			this.bKillTest.Location = new System.Drawing.Point(9, 44);
			this.bKillTest.Name = "bKillTest";
			this.bKillTest.Size = new System.Drawing.Size(97, 23);
			this.bKillTest.TabIndex = 34;
			this.bKillTest.Text = "Kill Test";
			this.bKillTest.UseVisualStyleBackColor = true;
			this.bKillTest.Click += new System.EventHandler(this.BKillTestClick);
			// 
			// gbTestbrowsers
			// 
			this.gbTestbrowsers.Controls.Add(this.cbSafari);
			this.gbTestbrowsers.Controls.Add(this.cbFirefoxproxy);
			this.gbTestbrowsers.Controls.Add(this.cbFirefoxPi);
			this.gbTestbrowsers.Controls.Add(this.cbIEpi);
			this.gbTestbrowsers.Controls.Add(this.cbIE);
			this.gbTestbrowsers.Controls.Add(this.cbFirefoxchrome);
			this.gbTestbrowsers.Controls.Add(this.tbOtherbrowser);
			this.gbTestbrowsers.Controls.Add(this.cbOtherbrowser);
			this.gbTestbrowsers.Controls.Add(this.cbSafariproxy);
			this.gbTestbrowsers.Controls.Add(this.cbIEhta);
			this.gbTestbrowsers.Controls.Add(this.cbOpera);
			this.gbTestbrowsers.Controls.Add(this.cbFirefox);
			this.gbTestbrowsers.Controls.Add(this.cbGooglechrome);
			this.gbTestbrowsers.Location = new System.Drawing.Point(425, 2);
			this.gbTestbrowsers.Name = "gbTestbrowsers";
			this.gbTestbrowsers.Size = new System.Drawing.Size(381, 207);
			this.gbTestbrowsers.TabIndex = 32;
			this.gbTestbrowsers.TabStop = false;
			this.gbTestbrowsers.Text = "Test browsers";
			// 
			// cbSafari
			// 
			this.cbSafari.Enabled = false;
			this.cbSafari.Location = new System.Drawing.Point(250, 31);
			this.cbSafari.Name = "cbSafari";
			this.cbSafari.Size = new System.Drawing.Size(86, 18);
			this.cbSafari.TabIndex = 39;
			this.cbSafari.Tag = "safari";
			this.cbSafari.Text = "Apple Safari";
			this.cbSafari.UseVisualStyleBackColor = true;
			// 
			// cbFirefoxproxy
			// 
			this.cbFirefoxproxy.Enabled = false;
			this.cbFirefoxproxy.Location = new System.Drawing.Point(8, 88);
			this.cbFirefoxproxy.Name = "cbFirefoxproxy";
			this.cbFirefoxproxy.Size = new System.Drawing.Size(157, 24);
			this.cbFirefoxproxy.TabIndex = 38;
			this.cbFirefoxproxy.Tag = "firefoxproxy";
			this.cbFirefoxproxy.Text = "Mozilla Firefox (proxy)";
			this.cbFirefoxproxy.UseVisualStyleBackColor = true;
			// 
			// cbFirefoxPi
			// 
			this.cbFirefoxPi.Enabled = false;
			this.cbFirefoxPi.Location = new System.Drawing.Point(9, 107);
			this.cbFirefoxPi.Name = "cbFirefoxPi";
			this.cbFirefoxPi.Size = new System.Drawing.Size(223, 24);
			this.cbFirefoxPi.TabIndex = 37;
			this.cbFirefoxPi.Tag = "pifirefox";
			this.cbFirefoxPi.Text = "Mozilla Firefox (proxy injection)";
			this.cbFirefoxPi.UseVisualStyleBackColor = true;
			// 
			// cbIEpi
			// 
			this.cbIEpi.Enabled = false;
			this.cbIEpi.Location = new System.Drawing.Point(8, 33);
			this.cbIEpi.Name = "cbIEpi";
			this.cbIEpi.Size = new System.Drawing.Size(223, 24);
			this.cbIEpi.TabIndex = 36;
			this.cbIEpi.Tag = "piiexplore";
			this.cbIEpi.Text = "Internet Explorer (proxy injection)";
			this.cbIEpi.UseVisualStyleBackColor = true;
			// 
			// cbIE
			// 
			this.cbIE.Enabled = false;
			this.cbIE.Location = new System.Drawing.Point(8, 15);
			this.cbIE.Name = "cbIE";
			this.cbIE.Size = new System.Drawing.Size(104, 24);
			this.cbIE.TabIndex = 35;
			this.cbIE.Tag = "iexplore";
			this.cbIE.Text = "Internet Explorer";
			this.cbIE.UseVisualStyleBackColor = true;
			// 
			// cbFirefoxchrome
			// 
			this.cbFirefoxchrome.Enabled = false;
			this.cbFirefoxchrome.Location = new System.Drawing.Point(9, 126);
			this.cbFirefoxchrome.Name = "cbFirefoxchrome";
			this.cbFirefoxchrome.Size = new System.Drawing.Size(239, 24);
			this.cbFirefoxchrome.TabIndex = 34;
			this.cbFirefoxchrome.Tag = "chrome";
			this.cbFirefoxchrome.Text = "Mozilla Firefox (elevated security privileges)";
			this.cbFirefoxchrome.UseVisualStyleBackColor = true;
			// 
			// tbOtherbrowser
			// 
			this.tbOtherbrowser.Enabled = false;
			this.tbOtherbrowser.Location = new System.Drawing.Point(69, 176);
			this.tbOtherbrowser.Name = "tbOtherbrowser";
			this.tbOtherbrowser.Size = new System.Drawing.Size(300, 20);
			this.tbOtherbrowser.TabIndex = 33;
			// 
			// cbOtherbrowser
			// 
			this.cbOtherbrowser.Enabled = false;
			this.cbOtherbrowser.Location = new System.Drawing.Point(9, 174);
			this.cbOtherbrowser.Name = "cbOtherbrowser";
			this.cbOtherbrowser.Size = new System.Drawing.Size(71, 24);
			this.cbOtherbrowser.TabIndex = 25;
			this.cbOtherbrowser.Text = "Custom:";
			this.cbOtherbrowser.UseVisualStyleBackColor = true;
			this.cbOtherbrowser.CheckedChanged += new System.EventHandler(this.CbOtherbrowserCheckedChanged);
			// 
			// lCreditCreator
			// 
			this.lCreditCreator.Location = new System.Drawing.Point(6, 39);
			this.lCreditCreator.Name = "lCreditCreator";
			this.lCreditCreator.Size = new System.Drawing.Size(142, 20);
			this.lCreditCreator.TabIndex = 36;
			this.lCreditCreator.Text = "Created  by Freek borgerink";
			// 
			// lCreditSelenium
			// 
			this.lCreditSelenium.Location = new System.Drawing.Point(6, 59);
			this.lCreditSelenium.Name = "lCreditSelenium";
			this.lCreditSelenium.Size = new System.Drawing.Size(246, 20);
			this.lCreditSelenium.TabIndex = 37;
			this.lCreditSelenium.Text = "Selenium Stanadlone server created by Selenium";
			this.lCreditSelenium.Click += new System.EventHandler(this.LCreditSeleniumClick);
			// 
			// lAboutVersionnr
			// 
			this.lAboutVersionnr.Location = new System.Drawing.Point(45, 23);
			this.lAboutVersionnr.Name = "lAboutVersionnr";
			this.lAboutVersionnr.Size = new System.Drawing.Size(32, 17);
			this.lAboutVersionnr.TabIndex = 34;
			this.lAboutVersionnr.Text = "1.0";
			// 
			// lVersion
			// 
			this.lVersion.Location = new System.Drawing.Point(6, 23);
			this.lVersion.Name = "lVersion";
			this.lVersion.Size = new System.Drawing.Size(43, 12);
			this.lVersion.TabIndex = 35;
			this.lVersion.Text = "Version";
			// 
			// gbCredits
			// 
			this.gbCredits.Controls.Add(this.lVersion);
			this.gbCredits.Controls.Add(this.lCreditSelenium);
			this.gbCredits.Controls.Add(this.lAboutVersionnr);
			this.gbCredits.Controls.Add(this.lCreditCreator);
			this.gbCredits.Location = new System.Drawing.Point(548, 215);
			this.gbCredits.Name = "gbCredits";
			this.gbCredits.Size = new System.Drawing.Size(258, 147);
			this.gbCredits.TabIndex = 38;
			this.gbCredits.TabStop = false;
			this.gbCredits.Text = "Credits";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 383);
			this.Controls.Add(this.gbCredits);
			this.Controls.Add(this.gbTestbrowsers);
			this.Controls.Add(this.gbTest);
			this.Controls.Add(this.gbStatusbox);
			this.Controls.Add(this.gbTestfile);
			this.Controls.Add(this.gbAppsettings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Testsuite Starter";
			this.gbTestfile.ResumeLayout(false);
			this.gbTestfile.PerformLayout();
			this.gbAppsettings.ResumeLayout(false);
			this.gbAppsettings.PerformLayout();
			this.gbStatusbox.ResumeLayout(false);
			this.gbStatusbox.PerformLayout();
			this.gbTest.ResumeLayout(false);
			this.gbTestbrowsers.ResumeLayout(false);
			this.gbTestbrowsers.PerformLayout();
			this.gbCredits.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox gbCredits;
		private System.Windows.Forms.Label lCreditCreator;
		private System.Windows.Forms.Label lCreditSelenium;
		private System.Windows.Forms.Button bKillTest;
		private System.Windows.Forms.GroupBox gbTest;
		private System.Windows.Forms.TextBox tbPortnr;
		private System.Windows.Forms.Label lPortnr;
		private System.Windows.Forms.Label lVersion;
		private System.Windows.Forms.Label lAboutVersionnr;
		private System.Windows.Forms.CheckBox cbIEpi;
		private System.Windows.Forms.CheckBox cbFirefoxPi;
		private System.Windows.Forms.CheckBox cbSafari;
		private System.Windows.Forms.CheckBox cbSafariproxy;
		private System.Windows.Forms.CheckBox cbFirefoxproxy;
		private System.Windows.Forms.CheckBox cbIE;
		private System.Windows.Forms.CheckBox cbFirefoxchrome;
		private System.Windows.Forms.CheckBox cbIEhta;
		private System.Windows.Forms.CheckBox cbOtherbrowser;
		private System.Windows.Forms.TextBox tbOtherbrowser;
		private System.Windows.Forms.GroupBox gbTestbrowsers;
		private System.Windows.Forms.CheckBox cbWindowontop;
		private System.Windows.Forms.Label lOntop;
		private System.Windows.Forms.Button bShowlogs;
		private System.Windows.Forms.Button bClearStatus;
		private System.Windows.Forms.TextBox tbStatusbox;
		private System.Windows.Forms.GroupBox gbStatusbox;
		private System.Windows.Forms.GroupBox gbTestfile;
		private System.Windows.Forms.TextBox tbLooptimes;
		private System.Windows.Forms.Label lLoop;
		private System.Windows.Forms.Button bReset;
		private System.Windows.Forms.Button bSelectUserextension;
		private System.Windows.Forms.CheckBox cbOpera;
		private System.Windows.Forms.Label lUserextension;
		private System.Windows.Forms.TextBox tbUserextension;
		private System.Windows.Forms.Label lTestsuite;
		private System.Windows.Forms.Button bRuntest;
		private System.Windows.Forms.Button bLocSeleniumbinary;
		private System.Windows.Forms.TextBox tbLocSeleniumBinary;
		private System.Windows.Forms.GroupBox gbAppsettings;
		private System.Windows.Forms.Label lSeleniumbinary;
		private System.Windows.Forms.Button bSelectLoglocation;
		private System.Windows.Forms.Button bSelectTestform;
		private System.Windows.Forms.TextBox tbLocTestform;
		private System.Windows.Forms.Label lLoclog;
		private System.Windows.Forms.TextBox tbLocLog;
		private System.Windows.Forms.CheckBox cbGooglechrome;
		private System.Windows.Forms.CheckBox cbFirefox;
		
		
		
		
		void LCreditSeleniumClick(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://seleniumhq.org/");
		}
		
		
	}
}
