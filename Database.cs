using System;
using System.Data;
using System.Data.OleDb;    // Namespace for classes to use with an Access database
using System.Windows.Forms;

/*  ID
 *      Load and Update the Member Database, Kaleb Ehlert, 4/15/2018
 *  Purpose
 *      The purpose of the program is to implement GUI that display's a table of information from a database and display it
 *       on the form. Then allow the user to change data on the database if they want to.
 *  Form Controls
 *      lblMember: A label that shows the members of the database.
 *      dgdMember: A DataGridView that displays the contents/data of the database.
 *      btnLoadData: A button that loads in the data from the database.
 *      btnUpdateData: A button that updates the database with the data the user has entered on the form.
 *  Code & Logic
 *      The input is either the keyboard text the user enters.
 *      The processing updates the database with the new information.
 *      The output is the data from the database.
 */

namespace EhlertProgram11
{
    public partial class frmDatabase : Form
    {
        private string connectionString;
        private string sqlCommand;
        private OleDbCommandBuilder commandBuild;
        private OleDbCommand dbCommand;
        private OleDbConnection dbConnect;
        private OleDbDataAdapter memberAdapter;
        private DataSet memberDataSet;

        public frmDatabase()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            // Construct an OleDbConnectionobject using the connection string
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=member.accdb";
            dbConnect = new OleDbConnection(connectionString);

            // Assign the SQL command to select all records ordered by last, then first name
            sqlCommand = "SELECT * FROM memberTable ORDER BY LastName ASC, FirstName ASC;";

            // Construct an OleDbCommand object to hold the query text
            // Then tie the command object to the connection object
            dbCommand = new OleDbCommand();
            dbCommand.CommandText = sqlCommand;
            dbCommand.Connection = dbConnect;

            // Construct an OleDbDataAdapter object to exchange data between the source database and the DataSet
            //  object using the assigned select command
            memberAdapter = new OleDbDataAdapter();
            memberAdapter.SelectCommand = dbCommand;

            // Construct a DataSet object and fill with the member database data
            memberDataSet = new DataSet();
            memberAdapter.Fill(memberDataSet, "memberTable");

            // Connect the DataGridView to the DataSet
            dgdMember.DataSource = memberDataSet;
            dgdMember.DataMember = "memberTable";
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            // Construct a CommandBuilder object to automatically generate SQL
            commandBuild = new OleDbCommandBuilder(memberAdapter);

            // Use the DataAdapter's Update method to save changes from the DataSet diusplayed in the DataGridView
            //  to the source database
            memberAdapter.Update(memberDataSet, "memberTable");
        }
    }
}
