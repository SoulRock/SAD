using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMonitoringAndTaskDesignationSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            todoList.DrawMode = DrawMode.OwnerDrawVariable;
            progressList.DrawMode = DrawMode.OwnerDrawVariable;
            reviseList.DrawMode = DrawMode.OwnerDrawVariable;
            completedList.DrawMode = DrawMode.OwnerDrawVariable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            todoList.Items.Add(textBox1.Text);
        }
        //LISTBOX 1 ---------------------------------------------------------------------------------------------------------------------------
        private void todoList_MouseDown(object sender, MouseEventArgs e)
        {
            if (todoList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                progressList.ClearSelected();
                reviseList.ClearSelected();
                completedList.ClearSelected();



                todoList.DoDragDrop(todoList.SelectedItem.ToString(), DragDropEffects.Copy);




                //if (reviseList.Focused)
                //{
                //    reviseList.DoDragDrop(todoList.SelectedItem.ToString(), DragDropEffects.Copy);
                //}

            }
        }

        private void todoList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(todoList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void todoList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.ItemHeight = 50;
            }
        }

        private void todoList_DragDrop(object sender, DragEventArgs e)
        {
            if (progressList.SelectedIndex >= 0)
            {

                todoList.Items.Add(e.Data.GetData(DataFormats.Text));
                progressList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }

            if (reviseList.SelectedIndex >= 0)
            {
                todoList.Items.Add(e.Data.GetData(DataFormats.Text));
                reviseList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }

            if (completedList.SelectedIndex >= 0)
            {
                todoList.Items.Add(e.Data.GetData(DataFormats.Text));
                completedList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        private void todoList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
//LISTBOX 2 ----------------------------------------------------------------------------------------------------------------------
        private void progressList_MouseDown(object sender, MouseEventArgs e)
        {
            if (progressList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item.");

            }
            else
            {
                todoList.ClearSelected();
                reviseList.ClearSelected();
                completedList.ClearSelected();


                progressList.DoDragDrop(progressList.SelectedItem.ToString(), DragDropEffects.Copy);

                //if(reviseList.Focused){
                //    reviseList.DoDragDrop(progressList.SelectedItem.ToString(), DragDropEffects.Copy);
                //}


            }
        }

        private void progressList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(progressList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void progressList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.ItemHeight = 50;
            }
        }

        private void progressList_DragDrop(object sender, DragEventArgs e)
        {
            if (todoList.SelectedIndex >= 0)
            {

                progressList.Items.Add(e.Data.GetData(DataFormats.Text));
                todoList.Items.Remove(e.Data.GetData(DataFormats.Text));

            }

            if (reviseList.SelectedIndex >= 0)
            {
                progressList.Items.Add(e.Data.GetData(DataFormats.Text));
                reviseList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }

            if (completedList.SelectedIndex >= 0)
            {
                progressList.Items.Add(e.Data.GetData(DataFormats.Text));
                completedList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        private void progressList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        //LISTBOX 3 --------------------------------------------------------------------------------------------------------------------------
        private void reviseList_MouseDown(object sender, MouseEventArgs e)
        {
            if (reviseList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                todoList.ClearSelected();
                progressList.ClearSelected();
                completedList.ClearSelected();


                reviseList.DoDragDrop(reviseList.SelectedItem.ToString(), DragDropEffects.Copy);

                //if (progressList.Focused)
                //{
                //    progressList.DoDragDrop(reviseList.SelectedItem.ToString(), DragDropEffects.Copy);
                //}


            }
        }

        private void reviseList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(reviseList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void reviseList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.ItemHeight = 50;
            }
        }

        private void reviseList_DragDrop(object sender, DragEventArgs e)
        {
            if (todoList.SelectedIndex >= 0)
            {

                reviseList.Items.Add(e.Data.GetData(DataFormats.Text));
                todoList.Items.Remove(e.Data.GetData(DataFormats.Text));

            }


            if (progressList.SelectedIndex >= 0)
            {
                reviseList.Items.Add(e.Data.GetData(DataFormats.Text));
                progressList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }

            if (completedList.SelectedIndex >= 0)
            {
                reviseList.Items.Add(e.Data.GetData(DataFormats.Text));
                completedList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        private void reviseList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        //LISTBOX 4 --------------------------------------------------------------------------------------------------------------------------
        private void completedList_MouseDown(object sender, MouseEventArgs e)
        {
            if (completedList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                todoList.ClearSelected();
                progressList.ClearSelected();
                reviseList.ClearSelected();


                completedList.DoDragDrop(completedList.SelectedItem.ToString(), DragDropEffects.Copy);




            }
        }

        private void completedList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(completedList.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void completedList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.ItemHeight = 50;
            }
        }

        private void completedList_DragDrop(object sender, DragEventArgs e)
        {
            if (todoList.SelectedIndex >= 0)
            {

                completedList.Items.Add(e.Data.GetData(DataFormats.Text));
                todoList.Items.Remove(e.Data.GetData(DataFormats.Text));

            }


            if (progressList.SelectedIndex >= 0)
            {
                completedList.Items.Add(e.Data.GetData(DataFormats.Text));
                progressList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }

            if (reviseList.SelectedIndex >= 0)
            {
                completedList.Items.Add(e.Data.GetData(DataFormats.Text));
                reviseList.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        private void completedList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
