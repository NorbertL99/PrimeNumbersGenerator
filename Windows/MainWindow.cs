// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                                    // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;                                                                                                        // Allow to work with files
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Numbers_Generator
{
    public partial class MainWindow : Form
    {
        static int controlValue = 0;                                                                                    // This control value variable managament stop/start generators
        public MainWindow()                                                                                             // This method run when window open
        {
            InitializeComponent();                                                                                      // Initialize components
        }

        private async void generateFromToBT_Click(object sender, EventArgs e)                                           // This method run when click event on generateFromToBT
        {
            try                                                                                                         // Support errors
            {
                if (fromNumberTB.Text == "" || toNumberTB.Text == "")                                                   // If some of gaps is empty                      
                {
                    MessageBox.Show("You need to give values for generator !", "Error",                                 // Inform user about empty gaps
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                                    // Set buttons and icon for messagabox
                    return;                                                                                             // Stoping method
                }
                int from = Convert.ToInt32(fromNumberTB.Text);                                                          // This variable store from with number we generete prime numbers
                int to = Convert.ToInt32(toNumberTB.Text);                                                              // This variable store to with number we generete prime numbers
                logsL.Text = "Generetign from " + from.ToString() + " to " + to.ToString() + " now " + from.ToString(); // Set log info for user
                disableGUI();                                                                                           // Run disableGUI method
                int asyncControl;                                                                                       // This variable store value returned by primeNumbersChecker
                for (int i = from; i <= to; i++)                                                                        // From i = 1 while i is smaller or equal to to add 1 to i
                {
                    if (controlValue == 0)                                                                              // If control value is 0
                    {
                        asyncControl = await primeNumbersChecker(i);                                                    // Set value of asyncControl with value returned by primeNumbersChecker with given argument i
                        if (asyncControl == 1)                                                                          // If returned value is 1
                        {
                            effectRTB.Text = effectRTB.Text + i.ToString() + '\n';                                      // Add i to effectRTB in new line
                        }
                        logsL.Text = "Generetign from " + from.ToString() + " to "                                      // Set log info for user
                                + to.ToString() + " now " + i.ToString();                                               // Set log info for user
                    }
                    else                                                                                                // If controlValue is diffrent than 0
                    {
                        controlValue = 0;                                                                               // Set controlValue as 0
                        MessageBox.Show("Genereting ended !", "Information",                                            // Inform user about generetor ended work
                            MessageBoxButtons.OK, MessageBoxIcon.Information);                                          // Set buttons and icon for messagabox
                        return;                                                                                         // Stoping generator
                    }
                }
                enableGUI();                                                                                            // Run enableGUI method if everything ended
            }
            catch (Exception exception)                                                                                 // If some errors found
            {
                MessageBox.Show("Some error founded, contact admin \n" + exception.ToString(), "Error",                 // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                        // Set buttons and icon for messagebox
            }
        }

        private async void generateFromHowBT_Click(object sender, EventArgs e)                                          // This method run when click event on generateFromHowBT
        {
            try                                                                                                         // Support errors
            {
                if (fromHowNumberTB.Text == "" || howManyTB.Text == "")                                                 // If some of gaps is empty                      
                {
                    MessageBox.Show("You need to give values for generator !", "Error",                                 // Inform user about empty gaps
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                                    // Set buttons and icon for messagabox
                    return;                                                                                             // Stoping method
                }
                int from = Convert.ToInt32(fromHowNumberTB.Text);                                                       // This variable store from with number we generete prime numbers
                int howMany = Convert.ToInt32(howManyTB.Text);                                                          // This variable store info about how many numbers we have to generate
                int alreadyGenereted = 0;                                                                               // This variable store info about how many numbers we already genereted
                logsL.Text = "Genereting " + howMany.ToString() + " numbers, from " + from.ToString();                  // Set logs info for user
                disableGUI();                                                                                           // Run disableGUI method
                int asyncControl;                                                                                       // This variable store value returned by primeNumbersChecker
                for (int i = from; i > 0; i++)                                                                          // From i = 1 while i is bigger than 0 add 1 to i
                {
                    if (alreadyGenereted != howMany)
                    {
                        if (controlValue == 0)                                                                          // If control value is 0
                        {
                            asyncControl = await primeNumbersChecker(i);                                                // Set value of asyncControl with value returned by primeNumbersChecker with given argument i
                            if (asyncControl == 1)                                                                      // If returned value is 1
                            {
                                effectRTB.Text = effectRTB.Text + i.ToString() + '\n';                                  // Add i to effectRTB in new line
                                alreadyGenereted = alreadyGenereted + 1;                                                // Adding one to alreadyGenereted value
                                logsL.Text = "Genereting " + howMany.ToString() + " numbers, from " + from.ToString();  // Set logs info for user
                            }
                        }
                        else                                                                                            // If controlValue is diffrent than 0
                        {
                            controlValue = 0;                                                                           // Set controlValue as 0
                            MessageBox.Show("Genereting ended !", "Information",                                        // Inform user about generetor ended work
                                MessageBoxButtons.OK, MessageBoxIcon.Information);                                      // Set buttons and icon for messagabox
                            return;                                                                                     // Stoping generator
                        }
                    }
                    else
                    {
                        controlValue = 0;                                                                               // Set controlValue as 0
                        MessageBox.Show("Genereting ended !", "Information",                                            // Inform user about generetor ended work
                            MessageBoxButtons.OK, MessageBoxIcon.Information);                                          // Set buttons and icon for messagabox
                        return;                                                                                         // Stoping generator
                    }
                }
                enableGUI();                                                                                            // Run enableGUI method if everything ended
            }
            catch (Exception exception)                                                                                 // If some errors found
            {
                MessageBox.Show("Some error founded, contact admin \n" + exception.ToString(), "Error",                 // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                        // Set buttons and icon for messagebox
            }
        }

        private void saveBT_Click(object sender, EventArgs e)                                                           // This method run when click event on saveBT
        {
            if (saveEffect.ShowDialog() == DialogResult.OK)                                                             // If dialog result is ok
            {
                try                                                                                                     // Holding errors while saveing datas to file
                {
                    File.WriteAllText(saveEffect.FileName, effectRTB.Text);                                             // Saveing result rich text box text to chosen file
                }
                catch (Exception)                                                                                       // If some errors catched
                {
                    MessageBox.Show("Error while saveing file !", "Error",                                              // Inform user about error while saveing datas
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                                                    // Seting buttons and icon
                }
            }
            else                                                                                                        // If dialog result is not ok
            {
                MessageBox.Show("Error while opening file", "Error",                                                    // Inform user about something wrong with file
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                        // Seting buttons and icon
            }
        }

        private async void startBT_Click(object sender, EventArgs e)                                                    // This method run when click event on startBT
        {
            try                                                                                                         // Support errors
            {
                disableGUI();                                                                                           // Run disableGUI method
                int howManyNumbers = 0;                                                                                 // This variable store how many prime numbers were found
                int biggest = 2;                                                                                        // This variable store biggest founded number
                logsL.Text = "Already genereted " + howManyNumbers.ToString();                                          // Set logs text with info about how many numbers genereted
                int asyncControl;                                                                                       // This variable store value returned by primeNumbersChecker
                for (int i = 1; i > 0; i++)                                                                             // From i = 1 while i is bigger than 0 add 1 to i
                {
                    if (controlValue == 0)                                                                              // If control value is 0
                    {
                        asyncControl = await primeNumbersChecker(i);                                                    // Set value of asyncControl with value returned by primeNumbersChecker with given argument i
                        if (asyncControl == 1)                                                                          // If returned value is 1
                        {
                            howManyNumbers = howManyNumbers + 1;                                                        // Add one to founded prime numbers
                            effectRTB.Text = effectRTB.Text + i.ToString() + '\n';                                      // Add i to effectRTB in new line
                            logsL.Text = "Already genereted " + howManyNumbers.ToString() + " prime numbers";           // Change genereting logs with new value of howManyNumbers
                            biggest = i;                                                                                // Set biggest as i
                        }
                    }
                    else                                                                                                // If controlValue is diffrent than 0
                    {
                        controlValue = 0;                                                                               // Set controlValue as 0
                        MessageBox.Show("Genereting ended ! \nBiggest founded number: "                                 // Inform user about biggest founded number and genereting ended 
                            + biggest.ToString(), "Information",                                                        // Inform user about biggest founded number and genereting ended
                            MessageBoxButtons.OK, MessageBoxIcon.Information);                                          // Set buttons and icon for messagabox
                        return;                                                                                         // Stoping generator
                    }
                }
            }
            catch (Exception exception)                                                                                 // If some errors found
            {
                MessageBox.Show("Some error founded, contact admin \n" + exception.ToString(), "Error",                 // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                        // Set buttons and icon for messagebox
            }
        }

        private void stopBT_Click(object sender, EventArgs e)                                                       // This method run when click event on stopBT
        {
            controlValue = 1;                                                                                       // Set controlValue as 1
            enableGUI();                                                                                            // Run enableGUI method
        }

        private void clearBT_Click(object sender, EventArgs e)                                                      // This method run when click event on clearBT
        {
            effectRTB.Text = "";                                                                                    // Clearing effect text
            logsL.Text = "Generating logs";                                                                         // Refresh logs text
        }

        private void clearFromHowBT_Click(object sender, EventArgs e)                                               // This method run when click event on clearFromHowBT
        {
            fromHowNumberTB.Text = howManyTB.Text = "";                                                             // Setting text of each TextBox as empty
        }

        private void clearFromToBT_Click(object sender, EventArgs e)                                                // This method run when click event on clearFromToBT
        {
            fromNumberTB.Text = toNumberTB.Text = "";                                                               // Setting text of each TextBox as empty
        }
        
        private async Task<int> primeNumbersChecker(int numberToCheck)                                              // This method checking about number is prime number
        {
            return await Task.Run(() =>                                                                             // Run new task for return
            {
                if (numberToCheck == 1) return 0;                                                                   // If number is 1 return 0
                if (numberToCheck == 2) return 1;                                                                   // If number is 2 return 1
                for(int i = 2; i < numberToCheck; i++)                                                              // From i = 2 while i is numberToCheck - 1 do i++
                {
                    if (numberToCheck % i == 0) return 0;                                                           // If number modulo from i is 0, return 0
                }
                return 1;                                                                                           // If loop end without return, return 1
            });
        }

        private void disableGUI()                                                                                   // This method disable buttons in GUI
        {
            generateFromHowBT.Enabled = false;                                                                      // Disable button
            generateFromToBT.Enabled = false;                                                                       // Disable button
            startBT.Enabled = false;                                                                                // Disable button
            clearBT.Enabled = false;                                                                                // Disable button
            saveBT.Enabled = false;                                                                                 // Disable button
        }

        private void enableGUI()                                                                                    // This method enable buttons in GUI
        {
            generateFromHowBT.Enabled = true;                                                                       // Enable button
            generateFromToBT.Enabled = true;                                                                        // Enable button
            startBT.Enabled = true;                                                                                 // Enable button
            clearBT.Enabled = true;                                                                                 // Enable button
            saveBT.Enabled = true;                                                                                  // Enable button
        }
    }
}
