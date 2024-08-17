using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CMPG223_MedAppoint_Group59
{
    public partial class Regi : System.Web.UI.Page
    {
        // Open the database connection
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationDBConnectionString"].ConnectionString);

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (IsPostBack)
            {

                string firstName = Request.Form["firstName"];
                string lastName = Request.Form["lastName"];
                string contactNumber = Request.Form["contactNumber"];
                string email = Request.Form["email"];
                string password = Request.Form["password"];


                // Proceed only if the form fields are not empty
                if (!string.IsNullOrEmpty(firstName) &&
                    !string.IsNullOrEmpty(lastName) &&
                    !string.IsNullOrEmpty(contactNumber) &&
                    !string.IsNullOrEmpty(email) &&
                    !string.IsNullOrEmpty(password))
                {
                    try
                    {
                        {
                            conn.Open();

                            // Insert query
                            string insertQuery = "INSERT INTO Registration (FirstName, LastName, ContactNumber, EmailAddress, Password) " +
                                                "VALUES (@FirstName, @LastName, @ContactNumber, @EmailAddress, @Password)";

                            SqlCommand command = new SqlCommand(insertQuery, conn);
                            command.CommandTimeout = 1200;
                            // Add parameters
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@EmailAddress", email); // Corrected to match the SQL query
                            command.Parameters.AddWithValue("@Password", password);


                            int rowsAffected = command.ExecuteNonQuery(); // Get the number of rows affected
                            Response.Write(rowsAffected > 0 ? "Insert Successful!" : "Insert Failed.");

                            // Execute the query
                            command.ExecuteNonQuery();


                            conn.Close(); // Close the connection
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error: " + ex.Message);
                    }
                }
                else
                {
                    Response.Write("All fields are required.");
                }
            }
        }
    }
}

