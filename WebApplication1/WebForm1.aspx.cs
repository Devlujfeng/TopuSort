using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[,] matrix = new string[13,13];
            for(int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    matrix[i, j] = "0";
                }

            }

            IEnumerable myList = new List<ModelList.ModelList>
            {
                new ModelList.ModelList{X = "0",Y = "1"},
                new ModelList.ModelList{X = "0",Y = "5"},
                new ModelList.ModelList{X = "2",Y = "0"},
                new ModelList.ModelList{X = "2",Y = "3"},
                new ModelList.ModelList{X = "3",Y = "5"},
                new ModelList.ModelList{X = "5",Y = "4"},
                new ModelList.ModelList{X = "6",Y = "4"},
                new ModelList.ModelList{X = "6",Y = "9"},
                new ModelList.ModelList{X = "7",Y = "6"},
                new ModelList.ModelList{X = "8",Y = "7"},
                new ModelList.ModelList{X = "9",Y = "10"},
                new ModelList.ModelList{X = "9",Y = "11"},
                new ModelList.ModelList{X = "9",Y = "12"},
                new ModelList.ModelList{X = "11",Y = "12"}
            };

            UpdateMatrix((List<ModelList.ModelList>)myList, ref matrix);
            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
            NumberRepeater.DataSource = matrix;
            NumberRepeater.DataBind();
        }
        public void UpdateMatrix(List<ModelList.ModelList> mtxList, ref string[,] matrix)
        {
            foreach (ModelList.ModelList item in mtxList)
            {
                matrix[Convert.ToInt32(item.X), Convert.ToInt32(item.Y)] = "1";
            }
        }

        protected void BeforeDisplayList(object sender, RepeaterItemEventArgs e)
        {
            Label lbl = e.Item.FindControl("Label1") as Label;
            int position = e.Item.ItemIndex;
            int divider = 13;
            int remainder;
            int rowNumber = Math.DivRem(position + 1, divider, out remainder);
            TableRow tr = new TableRow();
            TableCell td = new TableCell();
            if (remainder == 0 && lbl != null)
            {
                if(rowNumber != 0)
                {
                    
                    e.Item.Controls.AddAt(e.Item.Controls.IndexOf(lbl) + 1, tr);

                }
            }
            else if(remainder == 1)
            {
                if (lbl != null)
                {
                    td.Text = rowNumber.ToString();
                    td.Style.Add(HtmlTextWriterStyle.FontWeight, "600");
                    e.Item.Controls.AddAt(e.Item.Controls.IndexOf(lbl) - 1, td);
                }
            }
            if (lbl != null)
            {
                lbl.Text = e.Item.DataItem.ToString();
            }
            //DataBinder.Eval(e.Item.DataItem, "X").ToString();   
        }
    }
}