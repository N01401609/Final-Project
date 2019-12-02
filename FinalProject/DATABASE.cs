using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Diagnostics;

//This Code uses Christine's School System code as a reference
namespace FinalProject
{
    public class DATABASE
    {
      
        private static string User { get { return "root"; } }
        private static string Password { get { return ""; } }
        private static string Database { get { return "pagesdb"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //ConnectionString is something that we use to connect to a database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }
        // GETTING THE DATABASE INFORMATION
        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            // try{} catch{} will attempt to do everything inside try{}
            // if an error happens inside try{}, then catch{} will execute instead.
            // very useful for debugging without the whole program crashing!
            // this can be easily abused and should be used sparingly.
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                //open the db connection
                Connect.Open();
                //give the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();


                //for every row in the result set
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }//end row
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }

        public HTTP_PAGE FindPage(int id)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            HTTP_PAGE result_page = new HTTP_PAGE();

            try
            {
                //Build a custom query with the id information provided
                string query = "select * from pages where PAGE_ID = " + id;
                Debug.WriteLine("Connection Initialized...");
                //open the db connection
                Connect.Open();
                //Run out query against the database
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                List<HTTP_PAGE> pages = new List<HTTP_PAGE>();

                //read through the result set
                while (resultset.Read())
                {
                    //information that will store a single student
                    HTTP_PAGE currentpage = new HTTP_PAGE();

                    //Look at each column in the result set row, add both the column name and the column value to our Student dictionary
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                        //can't just generically put data into a dictionary anymore
                        //must go through each column one by one to insert data into the right property
                        switch (key)
                        {
                            case "PAGE_TITLE":
                                currentpage.SetPageTitle(value);
                                break;
                            case "PAGE_BODY":
                                currentpage.SetPageContent(value);
                                break;
                        }

                    }
                    //Add the student to the list of students
                    pages.Add(currentpage);
                }

                result_page = pages[0]; //get the first student

            }
            catch (Exception ex)
            {
                //If something (anything) goes wrong with the try{} block, this block will execute
                Debug.WriteLine("Something went wrong in the find Student method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return result_page;
        }

        public void AddPage(HTTP_PAGE new_page)
        {

            string query = "insert into pages (PAGE_TITLE, PAGE_BODY) values ('{0}','{1}')";
            query = String.Format(query, new_page.GetPageTitle(), new_page.GetPageContent());


            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void DeletePage(int pageid)
        {
           
            //Deleting the page based on id
            string removespages = "delete from pages where page_id = {0}";
            removespages = String.Format(removespages, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //This command removes the page from database
            MySqlCommand cmd_removepages = new MySqlCommand(removespages, Connect);
            try
            {
                //Create the connection
                Connect.Open();
                //Then delete the record
                cmd_removepages.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepages);
            }
            catch (Exception ex)
            {
                //if this isn't working as intended, you can check debug>windows>output for the error message.
                Debug.WriteLine("Something went wrong in the delete Page Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();

        }


    }
}