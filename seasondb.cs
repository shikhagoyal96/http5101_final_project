using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HTTP_5101_FinalProject_N01329988
{
    public class seasondb
    {
        // reference taken from in-class example done by Christine Bittle during lecture hours for teaching us CRUD concept.

        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "seasondatabase"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

      
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

        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query" + query);
                
                Connect.Open();
               
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                
                MySqlDataReader resultset = cmd.ExecuteReader();

                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }
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
        

        
        public http_page FindPage(int seasonId)
        {
           
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            
            http_page result_season = new http_page();

            
            try
            {
                //finding a particular season based on seasonid information
                string query = "select * from season where seasonid = " + seasonId;
                Debug.WriteLine("Connection Initialized...");
               
                Connect.Open();
                
                MySqlCommand cmd = new MySqlCommand(query, Connect);
               
                MySqlDataReader resultset = cmd.ExecuteReader();

                 
                List<http_page> seasons = new List<http_page>();

                
                while (resultset.Read())
                {
                    
                    http_page currentseason = new http_page();

                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);

                        switch (key)
                        {                     
                            case "seasontitle":
                                currentseason.SetStitle(value);
                                break;
                            case "seasonbody":
                                currentseason.SetSbody(value);
                                break;                       
                        }
                    }
                   
                    seasons.Add(currentseason);
                }
                result_season = seasons[0]; 
            }
            catch (Exception ex) 
            {              
                Debug.WriteLine("Something went wrong in the find season method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");
            return result_season;
        }

       
        public void AddPage(http_page new_season)
        {
            Debug.WriteLine("Add query method started......");
            //adding a new season 
            string query = "insert into season (seasontitle, seasonbody) values ('{0}','{1}')";
            query = String.Format(query,new_season.GetStitle(), new_season.GetSbody());
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddSeason Method!");
                Debug.WriteLine(ex.ToString());
            }
            
            Connect.Close();
        }

       
        public void UpdatePage(int season_id, http_page new_season)
        {
            Debug.WriteLine("Update query method started......");
            //updating a particular season based on seasonid information
            string query = "update season set seasontitle ='{0}', seasonbody = '{1}' where seasonid = '{2}'";
            query = String.Format(query, new_season.GetStitle(), new_season.GetSbody(), season_id);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Execute query " + query);

            }
            catch(Exception e)
            {
                Debug.WriteLine("Something went wrong in the Update Method");
                Debug.WriteLine(e.ToString());
            }
            Connect.Close();
        }

        
        public void DeletePage(int season_id)
        {
            Debug.WriteLine("Delete query method started......");
            //deleting a season based on seasonid information
            string query = "delete from season where seasonid = {0}";
            query = String.Format(query, season_id);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Something went wrong in the DeleteSeason Method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
        }
    }
}