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
       // DeleteCommand="DELETE FROM [services] WHERE [id] = @id" 
       //InsertCommand="INSERT INTO [services] ([title], [descripion], [status]) VALUES (@title, @descripion, @status)" 
      // ProviderName="<%$ ConnectionStrings:DatabaseConnectionString1.ProviderName %>" 
      // SelectCommand="SELECT [id], [title], [descripion], [status] FROM [services]" 
        //UpdateCommand="UPDATE [services] SET [title] = @title, [descripion] = @descripion, [status] = @status WHERE [id] = @id">
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       if(Button2.Text == "submit")
       {
           SqlCommand cmd = new SqlCommand("INSERT INTO [services] ([title], [descripion], [status]) VALUES (@title, @descripion, @status)", con);
           cmd.Parameters.AddWithValue("@title", TextBox1.Text.Trim());
           cmd.Parameters.AddWithValue("@descripion", TextBox2.Text.Trim());
           cmd.Parameters.AddWithValue("@status", RadioButtonList1.SelectedValue);
           
           con.Open();
           int s = cmd.ExecuteNonQuery();
           con.Close();
           if (s == 1)
           {
               TextBox1.Text = string.Empty;
               TextBox2.Text = string.Empty;
               RadioButtonList1.ClearSelection();
               Literal1.Text = "services inserted ";
               print();
               
           }
           else
           {
               TextBox1.Text = string.Empty;
               TextBox2.Text = string.Empty;
               RadioButtonList1.ClearSelection();
               print();
               Literal1.Text = "Error!";
           }

       }
        else
       {
           SqlCommand cmd = new SqlCommand("UPDATE [services] SET [title] = @title, [descripion] = @descripion, [status] = @status WHERE [id] = @id", con);
           cmd.Parameters.AddWithValue("@title", TextBox1.Text.Trim());
           cmd.Parameters.AddWithValue("@descripion", TextBox2.Text.Trim());
           cmd.Parameters.AddWithValue("@status", RadioButtonList1.SelectedValue);
           cmd.Parameters.AddWithValue("@id", ViewState["service_id"]);
           Button2.Text = "update";
           con.Open();
           int s = cmd.ExecuteNonQuery();
           con.Close();
           if (s == 1)
           {
               TextBox1.Text = string.Empty;
               TextBox2.Text = string.Empty;
               RadioButtonList1.ClearSelection();
               Button2.Text = "submit";
               print();
               Literal1.Text = "services update ";
           }
           else
           {
               TextBox1.Text = string.Empty;
               TextBox2.Text = string.Empty;
               RadioButtonList1.ClearSelection();
               print();
               Button2.Text = "submit";
               Literal1.Text = "Error!";
           }


       
       }
    }
    public void print()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [title], [descripion], [status] FROM [services]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //edit
        Button btn = (Button)sender;
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [id], [title], [descripion], [status] FROM [services]  WHERE [id] =" + btn.CommandArgument, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        TextBox1.Text = dt.Rows[0][1].ToString();
        TextBox2.Text = dt.Rows[0][2].ToString();
        RadioButtonList1.SelectedValue = dt.Rows[0][3].ToString();
        ViewState["service_id"] = btn.CommandArgument;
        Button2.Text = "update";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //delete
        Button btn = (Button)sender;
        SqlCommand cmd = new SqlCommand("DELETE FROM [services] WHERE [id] = @id", con);
        cmd.Parameters.AddWithValue("@id", btn.CommandArgument);
        con.Open();
        int s = cmd.ExecuteNonQuery();
        con.Close();
        if (s == 1)
        {
            Literal1.Text = "user deleted ";
        }
    }
}