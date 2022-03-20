using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString1"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        print();
        // DeleteCommand="DELETE FROM [category] WHERE [id] = @id" 
        //InsertCommand="INSERT INTO [category] ([category], [status]) VALUES (@category, @status)" 
        //ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
        //SelectCommand="SELECT [id], [category], [status] FROM [category]" 
        //UpdateCommand="UPDATE [category] SET [category] = @category, [status] = @status WHERE [id] = @id">

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //edit
        Button btn = (Button)sender;
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [category], [status] FROM [category]  WHERE [id] =" + btn.CommandArgument, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        TextBox1.Text = dt.Rows[0][1].ToString();
       
        RadioButtonList1.SelectedValue = dt.Rows[0][2].ToString();
        ViewState["category_id"] = btn.CommandArgument;
        Button2.Text = "update";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //delete
        Button btn = (Button)sender;
        SqlCommand cmd = new SqlCommand("DELETE FROM [category] WHERE [id] = @id", con);
        cmd.Parameters.AddWithValue("@id", btn.CommandArgument);
        con.Open();
        int s = cmd.ExecuteNonQuery();
        con.Close();
        if (s == 1)
        {
            Literal1.Text = "catrgory deleted ";
            print();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Button2.Text == "submit")
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [category] ([category], [status]) VALUES (@category, @status)", con);
            cmd.Parameters.AddWithValue("@category", TextBox1.Text.Trim());
            
            cmd.Parameters.AddWithValue("@status", RadioButtonList1.SelectedValue);

            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                TextBox1.Text = string.Empty;
                
                RadioButtonList1.ClearSelection();
                Literal1.Text = "category inserted ";
                print();

            }
            else
            {
                TextBox1.Text = string.Empty;
               
                RadioButtonList1.ClearSelection();
                print();
                Literal1.Text = "Error!";
            }

        }
        else
        {
            SqlCommand cmd = new SqlCommand("UPDATE [category] SET [category] = @category, [status] = @status WHERE [id] = @id", con);
            cmd.Parameters.AddWithValue("@category", TextBox1.Text.Trim());
          
            cmd.Parameters.AddWithValue("@status", RadioButtonList1.SelectedValue);
            cmd.Parameters.AddWithValue("@id", ViewState["category_id"]);
            Button2.Text = "update";
            con.Open();
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s == 1)
            {
                TextBox1.Text = string.Empty;
                
                RadioButtonList1.ClearSelection();
                Button2.Text = "submit";
                print();
                Literal1.Text = "category update ";
            }
            else
            {
                TextBox1.Text = string.Empty;
               
                RadioButtonList1.ClearSelection();
                print();
                Button2.Text = "submit";
                Literal1.Text = "Error!";
            }
        }
    }
    public void print()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [category], [status] FROM [category]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}