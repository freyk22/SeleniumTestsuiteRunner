/*
 * Gemaakt met SharpDevelop.
 * Gebruiker: freek
 * Datum: 1-3-2012
 * Tijd: 16:40
 * 
 * Dit sjabloon wijzigen: Extra | Opties |Coderen | Standaard kop bewerken.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

//for textsearch
using System.Text;
using System.Text.RegularExpressions;



namespace seltest
{
	/// <summary>
	/// Source for Testsuite starter
	/// Written by Freek Borgerink
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//set the default settings
			string strAppPath = Path.GetDirectoryName(Application.ExecutablePath);
			tbLocSeleniumBinary.Text = strAppPath + "\\" + "selenium-server-standalone-2.18.0.jar";
			tbLocLog.Text = strAppPath + "\\" + "logs\\";
			tbUserextension.Text = strAppPath + "\\" + "user-extensions.js";
			tbLooptimes.Text = "1";

		}

		
		
	public void BSelectTestformClick(object sender, EventArgs e)
		{
		//Selection Testsuite file	
			OpenFileDialog TestformSelect = new OpenFileDialog();
			TestformSelect.Title = "Select Testsuite file" ;
			TestformSelect.InitialDirectory = ".\\" ;
    		TestformSelect.Filter = "TestSuite files (*.html)|*.html" ;
    		TestformSelect.FilterIndex = 2 ;
    		TestformSelect.RestoreDirectory = true ;
			string strtestformfilename = ""; 
			string strtestformpath = ""; 
			string strbackslash = "\\";
			string strtestformlocation = "";
			string strtestformselected = "0";
			
	         if (TestformSelect.ShowDialog() == DialogResult.OK) 
	         { 
	         	strtestformfilename = System.IO.Path.GetFileName(TestformSelect.FileName);
	            strtestformpath = System.IO.Path.GetDirectoryName(TestformSelect.FileName);
	            //Put the path of the textfile in strtestformlocation
	         	strtestformlocation = strtestformpath + strbackslash + strtestformfilename;
	            strtestformselected = "1";
	         } else
	         {
	         	strtestformselected = "0";
	         }
 			
	         
	     
	           if (strtestformselected == "1")
        		{
		            //Check if the selected file is a "testsuite".
			         //Checkmethod: Open file and look for word "suiteTable"
			        string strFTtestformfilename = strtestformlocation;
		            StreamReader testTxt = new StreamReader(strFTtestformfilename);
		            string allRead = testTxt.ReadToEnd();
		            testTxt.Close();
		            string regMatch = "suiteTable"; 
		            if (Regex.IsMatch(allRead,regMatch))
		            {
					//If selected file is a testsuite, 
		            //Enable Buttons
	            	tbLocTestform.Enabled = true;
					tbLocTestform.Text = strtestformlocation;
					bSelectUserextension.Enabled = true;
					bSelectLoglocation.Enabled = true;
					cbIE.Enabled = true;
					cbIEhta.Enabled = true;
					cbIEpi.Enabled = true;
					cbFirefoxproxy.Enabled=true;
					cbFirefox.Enabled=true;
					cbFirefoxPi.Enabled=true;
					cbFirefoxchrome.Enabled=true;
					cbGooglechrome.Enabled=true;
					cbOpera.Enabled=true;
					cbSafari.Enabled=true;
					cbSafariproxy.Enabled=true;
				    cbOtherbrowser.Enabled=true;
					cbWindowontop.Enabled=true;
				    bRuntest.Enabled=true;
				    bClearStatus.Enabled=true;
				    tbLooptimes.Enabled=true;
				    //bKillTest.Enabled=true;
            }
            else
            {
            	//if selected file is not a testsuite file
            	// Show a Messagebox
            	MessageBox.Show("The selected file \nis not a testsuite.",
								"Warning",
								MessageBoxButtons.OK,
								MessageBoxIcon.Warning,
								MessageBoxDefaultButton.Button1);
            }
        }
	         
	         
	        
	         
	         
         
		}
		
	public void BSelectLoglocationClick(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
			folderBrowserDialog1.Description = "Select the log folder";
			
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
			    tbLocLog.Text  = folderBrowserDialog1.SelectedPath ;
			}
	        tbLocLog.Enabled = true;
	        bSelectTestform.Enabled = true;
	        bShowlogs.Enabled = true;
	        
		}
		
	public void BSelectJavabinaryClick(object sender, EventArgs e)
		{
			//Open filedialog to select the java binary
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Select Java Binary";
			ofd.InitialDirectory = ".\\" ;
    		ofd.Filter = "Java Runtime Binary (java.exe)|java.exe" ;
    		ofd.FilterIndex = 2 ;
    		ofd.RestoreDirectory = true ;
			string strJavabinaryfilename = ""; 
			string strJavabinarypath = ""; 
			string backslash = "\\";
			string strJavabinarylocation = "";
	         if (ofd.ShowDialog() == DialogResult.OK) 
	         { 
	           strJavabinaryfilename = System.IO.Path.GetFileName(ofd.FileName); 
	           strJavabinarypath = System.IO.Path.GetDirectoryName(ofd.FileName); 
	         }   
	         
	         //Put the path of location of the javabinary to strJavabinarylocation
	         strJavabinarylocation = strJavabinarypath + backslash + strJavabinaryfilename;
	         bLocSeleniumbinary.Enabled = true;
	         bSelectTestform.Enabled=true;
		}
		
		
	public	void BLocSeleniumbinaryClick(object sender, EventArgs e)
		{
			//Open file dialog
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Select Selenium server java-binary";
			ofd.InitialDirectory = ".\\" ;
    		ofd.Filter = "selenium-server-standalone (*.jar)|selenium-server-*.jar" ;
    		ofd.FilterIndex = 2 ;
    		ofd.RestoreDirectory = true ;
			string strSeleniumbinaryfilename = ""; 
			string strSeleniumbinarypath = ""; 
			string backslash = "\\";
			string strSeleniumbinarylocation = "";
	         if (ofd.ShowDialog() == DialogResult.OK) 
	         { 
	         	strSeleniumbinaryfilename = System.IO.Path.GetFileName(ofd.FileName); 
	            strSeleniumbinarypath = System.IO.Path.GetDirectoryName(ofd.FileName); 
	         }   
	         //Put the path of location of the Selenium Server-jar package to strSeleniumbinarylocation
	         strSeleniumbinarylocation = strSeleniumbinarypath + backslash + strSeleniumbinaryfilename;
	         tbLocSeleniumBinary.Text = strSeleniumbinarylocation;
	         
	         //Enable buttons:
	         tbLocSeleniumBinary.Enabled=true;
	         tbLocLog.Enabled=true;
	         bSelectLoglocation.Enabled=true;
	         cbWindowontop.Enabled = true;
	         bReset.Enabled = true;
	         tbLooptimes.Enabled = true;
		}
			
		void bRuntestClick(object sender, EventArgs e)
		{
			//If the Run button is clicked, do the following things:
			
			//System.IO.Path.GetFileName(odfue.FileName);
			Text = System.IO.Path.GetFileName(tbLocTestform.Text) + " - Testsuite Runner";
	 		//Log the start to statusbox
	 		tbStatusbox.AppendText("\r\n** Test Start **");
	 		
	 		//Start with number 1, not 0
  			int loopammountold = Convert.ToInt32(tbLooptimes.Text);
  			int loopammount = loopammountold - 1;
  			int loopcount;
  			
  			//Loop the tasks
  			for(loopcount = 0; loopcount <= loopammount; loopcount = loopcount+1){
  				
	  			DateTime MyDateTime = DateTime.Now;
		 		string strDatestamp = MyDateTime.ToString("yyyyddhhmm");
  				
  				//Get the needed information from the textboxes and put it in strings
  				string loglocation = tbLocLog.Text;
				string filename_wo_ext = Path.GetFileNameWithoutExtension(loglocation);
	            string extension = Path.GetExtension(loglocation);
	            string directory = Path.GetDirectoryName(loglocation);
	            
	            //Setting applicationwindow on top
	            if (cbWindowontop.Checked){TopMost = true;}
		   		
				// set Userinput to variable
				string strSeleniumbinarylocation = tbLocSeleniumBinary.Text;
				string strtestformlocation = tbLocTestform.Text;
				string strBaseurl = "http://127.0.0.1";
				string strSelectedBrowsers = "";				
				string strUserExtension = tbUserextension.Text;
				
				// Get selected browsers and put in string strSelectedBrowsers
				if (cbFirefox.Checked){strSelectedBrowsers = strSelectedBrowsers + cbFirefox.Tag + ";";}
				if (cbFirefoxchrome.Checked){strSelectedBrowsers = strSelectedBrowsers + cbFirefoxchrome.Tag + ";";}
				if (cbFirefoxPi.Checked){strSelectedBrowsers = strSelectedBrowsers + cbFirefoxPi.Tag + ";";}
				if (cbFirefoxproxy.Checked){strSelectedBrowsers = strSelectedBrowsers + cbFirefoxproxy.Tag + ";";} 
				if (cbIE.Checked){strSelectedBrowsers = strSelectedBrowsers + cbIE.Tag + ";";}
				if (cbIEhta.Checked){strSelectedBrowsers = strSelectedBrowsers + cbIEhta.Tag + ";";}
				if (cbIEpi.Checked){strSelectedBrowsers = strSelectedBrowsers + cbIEpi.Tag + ";";}
				if (cbGooglechrome.Checked){strSelectedBrowsers = strSelectedBrowsers + cbGooglechrome.Tag + ";";}
				if (cbSafari.Checked){strSelectedBrowsers = strSelectedBrowsers +  cbSafari.Tag + ";" ;}
				if (cbSafariproxy.Checked){strSelectedBrowsers = strSelectedBrowsers +  cbSafariproxy.Tag + ";" ;}
				if (cbOpera.Checked){strSelectedBrowsers = strSelectedBrowsers +  cbOpera.Tag + ";" ;}
				if (cbOtherbrowser.Checked){strSelectedBrowsers = strSelectedBrowsers + tbOtherbrowser.Text + ";" ;}
				
				//Add selected browsers to status box
				tbStatusbox.AppendText("\r\n" + strDatestamp + " - Selected Browsers: " + strSelectedBrowsers);
				
				//Split the selected browsers in the strSelectedBrowsers and
				//put it in string SelectedBrowsers
				string[] SelectedBrowsers = strSelectedBrowsers.Split(';');
				
				
				//Run for every selected browser the following java execution
				foreach (string browser in SelectedBrowsers)
				{
					
					//Get loc location
					string strloglocation = tbLocLog.Text;
					
					//Display status in 
					tbStatusbox.AppendText("\r\n" + strDatestamp +" - " + loopcount +" - Running "+ strtestformlocation +" on " +browser);
					
					//Run selenium + selenium argument, with java
					Process runjava = new Process();
					runjava.StartInfo.FileName = "java";
					
					//Running java with the selected parameters
					//Selenium Parameters
					//example: "C:\Program Files (x86)\Java\jre6\bin\java.exe" -jar c:\seltest\selenium-server-standalone-2.18.0.jar -htmlSuite "*iehta" "http://feedback3.test.parantion.nl/?id=8f0a8955a75689c161281d167080ad2f" "c:\seltest\testsuite1.html" "c:\seltest\logs\results-iexplore.html" -port 5555 >> "c:\seltest\logs\results-shell.txt"
					//runjava.StartInfo.Arguments = "-jar \"" + strSeleniumbinarylocation + "\"" + " " + "-htmlSuite" + " " + "\"*" + browser + "\"" + " " + "\"" +  strBaseurl + "\"" + " " + "\"" + strtestformlocation + "\"" + " " + "\"" + tbLocLog.Text + "\\" + "log-" + browser + "-" + strDatestamp + "-" + loopcount + ".html" + "\"" + " " + "-userExtensions" + " " + "\"" + strUserExtension + "\"" + " " + "-port 5555";
					runjava.StartInfo.Arguments = "-jar \"" + strSeleniumbinarylocation + "\"" + " " + "-htmlSuite" + " " + "\"*" + browser + "\"" + " " + "\"" +  strBaseurl + "\"" + " " + "\"" + strtestformlocation + "\"" + " " + "\"" + tbLocLog.Text + "\\" + "log-" + browser + "-" + strDatestamp + "-" + loopcount + ".html" + "\"" + " " + "-userExtensions" + " " + "\"" + strUserExtension + "\"" + " " + "-port "+ tbPortnr.Text;
					runjava.Start();
					runjava.WaitForExit();
					
					////Test: start job and loose the focus of the java window.
					////doesnt work right: its works after a second job.
					// runjava.Start();
					// foreach (var process in Process.GetProcessesByName("java"))
					// {
				    // if (process.MainWindowTitle.EndsWith("java.exe"))
					//     {
					//         process.EnableRaisingEvents = true;
					//     }
					// }

					
				}
  			}
  			//add end status to statusbox
			tbStatusbox.AppendText("\r\n** Test end **");
			
			//Save content tbStatusbox.Text to file in logguilocation 
			string logguilocation = tbLocLog.Text;
			DateTime MyDateTime1 = DateTime.Now;
	 		string strDatestamp1 = MyDateTime1.ToString("yyyyddhhmm");
			StreamWriter sw = new StreamWriter(logguilocation +"\\log-taskrunner" + strDatestamp1  + ".txt");  
			//write file
			sw.WriteLine(tbStatusbox.Text);
			//Close file
			sw.Close();
			//disable on top function
			TopMost = false;
			cbWindowontop.Checked = false;
		}
		
		void BSelectUserextensionClick(object sender, EventArgs e)
		{
			//Open filedailog to select a user extension
			OpenFileDialog odfue = new OpenFileDialog();
			odfue.Title = "Select user extension";
			odfue.InitialDirectory = ".\\" ;
    		odfue.Filter = "User Extensions (user-extensions.js)|*.js" ;
    		odfue.FilterIndex = 2 ;
    		odfue.RestoreDirectory = true ;
			string strUserextensionfilename = ""; 
			string strUserextensionpath = ""; 
			string backslash = "\\";
			string strUserextensionlocation = "";
			if (odfue.ShowDialog() == DialogResult.OK)
	         { 
	           strUserextensionfilename = System.IO.Path.GetFileName(odfue.FileName); 
	           strUserextensionpath = System.IO.Path.GetDirectoryName(odfue.FileName); 
	         }   
	         strUserextensionlocation = strUserextensionpath + backslash + strUserextensionfilename;
	         tbUserextension.Text = strUserextensionlocation;
	         tbUserextension.Enabled = true;
		}
		
		void bResetClick(object sender, EventArgs e)
		{
			//If clicked, reset application settings:
			
		 	//set the default settings
			string strAppPath = Path.GetDirectoryName(Application.ExecutablePath);
			tbLocSeleniumBinary.Text = strAppPath + "\\" + "selenium-server-standalone-2.18.0.jar";
			tbLocLog.Text = strAppPath + "\\" + "logs\\";
			tbUserextension.Text = strAppPath + "\\" + "user-extensions.js";
			tbLooptimes.Text = "1";
			cbOtherbrowser.Enabled=false;
			
			//clean other textboxes
			tbLocTestform.Text = "";
			tbLocTestform.Text = "";
			tbOtherbrowser.Text = "";

		    //uncheck buttons
	    	cbFirefox.Checked= false;
			cbFirefoxchrome.Checked= false;
			cbFirefoxPi.Checked= false;
			cbFirefoxproxy.Checked= false;
			cbIE.Checked= false;
			cbIEhta.Checked= false;
			cbIEpi.Checked= false;
			cbGooglechrome.Checked= false;
			cbSafari.Checked= false;
			cbSafariproxy.Checked= false;
			cbOpera.Checked= false;
			cbOtherbrowser.Checked= false;
	    	
			//disable buttons
	    	cbFirefox.Enabled= false;
			cbFirefoxchrome.Enabled= false;
			cbFirefoxPi.Enabled= false;
			cbFirefoxproxy.Enabled= false;
			cbIE.Enabled= false;
			cbIEhta.Enabled= false;
			cbIEpi.Enabled= false;
			cbGooglechrome.Enabled= false;
			cbSafari.Enabled= false;
			cbSafariproxy.Enabled= false;
			cbOpera.Enabled= false;
			cbOtherbrowser.Enabled= false;
			bRuntest.Enabled=false;
	
		}
		
	
		
		void BClearStatusClick(object sender, EventArgs e)
		{
			//Clear status box
			tbStatusbox.Text = "";
		}
		
		void BShowlogsClick(object sender, EventArgs e)
		{
			//open logfolder (tbLocLog.Text) with explorer				
			string strLogfolder = tbLocLog.Text;
			string strwindir = Environment.GetEnvironmentVariable("WINDIR");
			System.Diagnostics.Process prc = new System.Diagnostics.Process();
			prc.StartInfo.FileName = strwindir + @"\explorer.exe";
			prc.StartInfo.Arguments = strLogfolder;
			prc.Start();
		}
		
		void CbOtherbrowserCheckedChanged(object sender, EventArgs e)
		{
			if (cbOtherbrowser.Checked){tbOtherbrowser.Enabled = true;}
		}
		
		
		void BKillTestClick(object sender, EventArgs e)
		{
			//Kill the Test.
			Process[] processes = Process.GetProcessesByName("java");
			foreach (Process process in processes)
			{
    			process.Kill();
			}
		}
		
	}
}
