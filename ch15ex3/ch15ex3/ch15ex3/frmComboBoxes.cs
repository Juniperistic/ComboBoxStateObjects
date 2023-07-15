using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*************************************************************************/
/* Program Name:     Ch15Ex3.cs                                          */
/* Date:             05/01/2022                                    	     */
/* Programmer:       Miranda Morris                                 	 */
/* Class:            CSCI 234                               		     */
/*                                                                       */
/* Program Description: The purpose of this program is to create 15      */
/* state objects within a combobox and the selected state gets removed.  */
/*                                                                       */
/* Input: Select a state from the comboBox								 */
/*                                                                       */
/* Output: The selected state gets removed from the ComboBox			 */
/*                                                                       */
/* Givens: The names of 15 states          								 */
/*                                                                       */
/* Testing Data: Screenshots included                                    */
/*                                                                       */
/* List the Testing Input Data:  Screenshots included                    */
/* I opened the program selected alabama and Washington which removed    */
/* them from the combobox                                                */
/*                                                                       */
/*************************************************************************/

namespace ch15ex3
{
    public partial class cmbStates : Form
    {
        public cmbStates()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void cmbStates_Load(object sender, EventArgs e)
        {
           
        }
    }
}
