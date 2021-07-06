using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void MakeButtonsInactive()
        {

            btn_Plus.Enabled = false;
            btn_Minus.Enabled = false;
            btn_Minus.Enabled = false;
            btn_Division.Enabled = false;
            btn_Percent.Enabled = false;
            btn_Equals.Enabled = false;
        }
        protected void MakeButtonsActive()
        {

            btn_Plus.Enabled = true;
            btn_Minus.Enabled = true;
            btn_Minus.Enabled = true;
            btn_Division.Enabled = true;
            btn_Percent.Enabled = true;
            btn_Equals.Enabled = true;
        }
        protected void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_DisplayValue.Text = "0";
            lbl_currentValue.Text = "#";
            lbl_PrevValue.Text = "#";
            lbl_symbol.Text = "#";
        }
        protected void ChangeNumber(string newDigit)
        {
            try
            {
                MakeButtonsActive();
                if (lbl_currentValue.Text == "#")
                {
                    if (newDigit != "0")
                    {
                        lbl_DisplayValue.Text = newDigit;
                        lbl_currentValue.Text = newDigit;
                    }
                }
                else
                {
                    lbl_currentValue.Text = lbl_currentValue.Text + newDigit;
                    lbl_DisplayValue.Text = lbl_currentValue.Text;
                }
            }
            catch(Exception e)
            {
                Response.Write(e);
            }
           
        }
        protected void btn_One_Click(object sender, EventArgs e)
        {

            ChangeNumber(btn_One.Text.ToString());
        }

        protected void btn_Two_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Two.Text.ToString());
        }

        protected void btn_Three_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Three.Text.ToString());
        }

        protected void btn_Four_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Four.Text.ToString());
        }

        protected void btn_Five_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Five.Text.ToString());
        }

        protected void btn_Six_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Six.Text.ToString());
        }

        protected void btn_Seven_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Seven.Text.ToString());
        }

        protected void btn_Eight_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Eight.Text.ToString());
        }

        protected void btn_Nine_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Nine.Text.ToString());
        }

        protected void btn_Zero_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Zero.Text.ToString());
        }

        protected void btn_Dot_Click(object sender, EventArgs e)
        {
            ChangeNumber(btn_Dot.Text.ToString());
        }
        protected void setLabelSymbol(int opSign)
        {
            if(opSign==1)
                lbl_symbol.Text = "+";
            else if (opSign == 2)
                lbl_symbol.Text = "-";
            else if (opSign == 3)
                lbl_symbol.Text = "*";
            else if (opSign == 4)
                lbl_symbol.Text = "/";
            else if (opSign == 5)
                lbl_symbol.Text = "%";

        }
        protected int getLabelSymbol()
        {
            if (lbl_symbol.Text == "+")
                return 1;
            else if (lbl_symbol.Text == "-")
                return 2;
            else if (lbl_symbol.Text == "*")
                return 3;
            else if (lbl_symbol.Text == "/")
                return 4;
            else if (lbl_symbol.Text == "%")
                return 5;
            else
                return 0;
        }
        protected void CalculateValue(int operatorSymbol)
        {
            try
            {

                if (lbl_symbol.Text == "#")
                {
                    lbl_PrevValue.Text = lbl_DisplayValue.Text;
                    lbl_currentValue.Text = "#";
                    MakeButtonsInactive();
                    setLabelSymbol(operatorSymbol);
                }
                else
                {
                    if (lbl_currentValue.Text != "#")
                    {
                        float result=0;
                        int currentOpSymbol = getLabelSymbol();
                        if(operatorSymbol!= currentOpSymbol)
                        {

                            setLabelSymbol(operatorSymbol);
                            
                        }
                        operatorSymbol = currentOpSymbol;
                         switch (operatorSymbol)
                        {
                            case 1:
                                result = float.Parse(lbl_PrevValue.Text) + float.Parse(lbl_DisplayValue.Text);
                                break;
                            case 2:
                                result = float.Parse(lbl_PrevValue.Text) - float.Parse(lbl_DisplayValue.Text);
                                break;
                            case 3:
                                result = float.Parse(lbl_PrevValue.Text) * float.Parse(lbl_DisplayValue.Text);
                                break;
                            case 4:
                                result = float.Parse(lbl_PrevValue.Text) / float.Parse(lbl_DisplayValue.Text);
                                break;
                            case 5:
                                result = float.Parse(lbl_PrevValue.Text) % float.Parse(lbl_DisplayValue.Text);
                                break;
                            default:
                                break;
                        }
                      
                        lbl_DisplayValue.Text = result.ToString();
                        lbl_DisplayValue.Visible = true;
                        lbl_PrevValue.Text = result.ToString();
                        lbl_currentValue.Text = "#";
                        MakeButtonsActive();
                    }
                    else
                    {
                        setLabelSymbol(operatorSymbol);

                    }
                }
                               
            }
            catch (Exception exp)
            {
                Response.Write(exp);
            }                                   
          
        }
       
        protected void btn_Plus_Click(object sender, EventArgs e)
        {
            CalculateValue(1);


        }
        protected void btn_Minus_Click(object sender, EventArgs e)
        {
            CalculateValue(2);
        }

        protected void btn_Multi_Click(object sender, EventArgs e)
        {
            CalculateValue(3);
        }

        protected void btn_Division_Click(object sender, EventArgs e)
        {
            CalculateValue(4);
        }

        protected void btn_Percent_Click(object sender, EventArgs e)
        {
            CalculateValue(5);
        }

        protected void btn_Equals_Click(object sender, EventArgs e)
        {
            if (lbl_symbol.Text != "#")
            {
                int lastOperator = getLabelSymbol();
                CalculateValue(lastOperator);
            }

               
        }

        /* protected void btn_BackSpace_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_currentValue.Text != "#")
                {
                    if (lbl_DisplayValue.Text.Length > 0)
                    {
                        lbl_DisplayValue.Text = lbl_DisplayValue.Text.Remove(lbl_DisplayValue.Text.Length - 1, 1);
                        lbl_currentValue.Text = lbl_DisplayValue.Text;
                    }
                    else
                    {
                        lbl_DisplayValue.Text = "0";
                        lbl_currentValue.Text = "#";
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
        */
    }
}