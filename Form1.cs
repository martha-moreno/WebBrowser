using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace MarthasBrowser
{
        public partial class Form1 : Form
        {
            
            public Form1()
            {
                
                InitializeComponent();
                
            }

            private void Form_Resize(object sender, EventArgs e)
            {
                
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }


            


            /*************************SIMPLE CALCULATOR CODE STARTS HERE***********************/
            // Button Calculate
            private void btnCalculate_Click(object sender, EventArgs e)
            {

               
                float result; //declaration of float variable for operation result

            //Declaration of Variables that hold operands and parse from string to float number 
            try
            {
                float operand1 = float.Parse(textNum1.Text);
                float operand2 = float.Parse(textNum2.Text); //
            

            int selectedIndex = comboOperation.SelectedIndex; //Grab index from combobox selected option to determine operation type

                //Calculations according to operation selected from combobox    
                switch (selectedIndex)
                {
                    case 0://Addition
                        result = operand1 + operand2;
                        textResult.Text = result.ToString();
                        break;
                    case 1://Substraction
                        result = operand1 - operand2;
                        textResult.Text = result.ToString();
                        break;
                    case 2://Multiplication
                        result = operand1 * operand2;
                        textResult.Text = result.ToString();
                        break;
                    case 3://Division
                        result = operand1 / operand2;
                        textResult.Text = result.ToString();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter numbers only");
            }


        }

            /*************************SIMPLE CALCULATOR CODE ENDS HERE***********************/



            /*************************WEB BROWSER FUNCTIONALITY CODE STARTS HERE***********************/
            //Button Go
            private void button1_Click(object sender, EventArgs e)
            {
                if (webView21 != null && webView21.CoreWebView2 != null)
                {
                    webView21.CoreWebView2.Navigate(textUrl.Text);
                }
            }
            /*************************WEB BROWSER FUNCTIONALITY CODE ENDS HERE***********************/


            /************************* TEXT ENCRYPTION/DECRYPTION CODE ENDS HERE***********************/
            //Button Submit string for encryption/decryption
            private void btn_Click(object sender, EventArgs e)
            {
                EncryptionService.ServiceClient myClient = new EncryptionService.ServiceClient();//Service Instance creation
                try
                {
                    label8.Text = myClient.Encrypt(text.Text);// Display of encrypted string in label
                }
                catch (Exception ec)
                {
                    label8.Text = ec.Message.ToString();
                }
                try
                {
                    label7.Text = myClient.Decrypt(label8.Text); // Display of decrypted string in label
                }
                catch (Exception dc)
                {
                    label7.Text = dc.Message.ToString();
                }
            }
            /*************************TEXT ENCRYPTION/DECRYPTION CODE ENDS HERE***********************/

            /*************************RANDOM STRING GENERATOR CODE ENDS HERE***********************/
            private void btnGenerate_Click(object sender, EventArgs e)
            {
                ServiceReference1.ServiceClient randomStringService = new ServiceReference1.ServiceClient();
                //int length = Int32.Parse(textLength.Text);
                string randomString = randomStringService.GetRandomString3(textLength.Text);
                GeneratedString.Text = randomString;

                // GeneratedString.Text = randomStringService.GetRandomString0();
            }

        private void textNum1_TextChanged(object sender, EventArgs e)
        {

        }
        /*************************RANDOM STRING GENERATOR CODE ENDS HERE***********************/
    }
 }
