using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Newtonsoft.Json;

namespace GoogleSheets
{
    internal class SheetOperations
    {

        public Google.Apis.Drive.v3.Data.File CreateSheet()
        {
            string[] scopes = new string[]
            {
                DriveService.Scope.Drive,
                DriveService.Scope.DriveFile,
            };

            var clientId = "190524179249-0qi0h9j6deiap0gj965ff1dian8k0h3q.apps.googleusercontent.com";

            var clientSecret = "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";

            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            },
            scopes,
            Environment.UserName, CancellationToken.None, new FileDataStore("MyAppToken")).Result;
            //Once consent is recieved, your token will be stored locally on the AppData directory, so that next time you wont be prompted for consent.   

            DriveService _service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "CsharpSheets"
            });
            var _parent = "1RO15nDox9pW5LNgz6I2CTywASwEQJDSt";//ID of folder if you want to create spreadsheet in specific folder

            var filename = "helloworld";

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = filename,
                MimeType = "application/vnd.google-apps.spreadsheet",
                //TeamDriveId = teamDriveID, // IF you want to add to specific team drive  
            };

            FilesResource.CreateRequest request = _service.Files.Create(fileMetadata);
            request.SupportsTeamDrives = true;
            fileMetadata.Parents = new List<string> { _parent };// Parent folder id or TeamDriveID  
            request.Fields = "id";
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            var file = request.Execute();
            MessageBox.Show("File ID: " + file.Id);
            return file;
        }
          

        public void UpdateSpreadSheet()
        {
            // SpreadhSheetID of above created document.  
            var SheetId = "1pbIfEWq-Y1tFtC6-1wyYcklwIhhODgkw-eizCZllUsc";
            var service = AuthorizeGoogleAppForSheetsService();
            string newRange = GetRange(service, SheetId);
            IList<IList<Object>> objNeRecords = GenerateData();
            UpdatGoogleSheetinBatch(objNeRecords, SheetId, newRange, service);
            MessageBox.Show("done");
        }


        private static SheetsService AuthorizeGoogleAppForSheetsService()
        {
            // If modifying these scopes, delete your previously saved credentials  
            // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json  
            string[] Scopes = { SheetsService.Scope.Spreadsheets };
            string ApplicationName = "Google Sheets API .NET Quickstart";
            UserCredential credential;
            using (var stream = new FileStream("spreadsheetcredentials.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore("MyAppToken")).Result;
            }

            // Create Google Sheets API service.  
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });


            return service;
        }

        protected static string GetRange(SheetsService service, string SheetId)
        {
            // Define request parameters.  
            String spreadsheetId = SheetId;
            String range = "A:A";

            SpreadsheetsResource.ValuesResource.GetRequest getRequest =
                       service.Spreadsheets.Values.Get(spreadsheetId, range);
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            ValueRange getResponse = getRequest.Execute();
            IList<IList<Object>> getValues = getResponse.Values;
            if (getValues == null)
            {
                // spreadsheet is empty return Row A Column A  
                return "A:A";
            }

            int currentCount = getValues.Count() + 1;
            String newRange = "A" + currentCount + ":A";
            return newRange;
        }

        private static IList<IList<Object>> GenerateData()
        {
            List<IList<Object>> objNewRecords = new List<IList<Object>>();
            int maxrows = 5;
            for (var i = 1; i <= maxrows; i++)
            {
                IList<Object> obj = new List<Object>();
                obj.Add("Data row value - " + i + "A");
                obj.Add("Data row value - " + i + "B");
                obj.Add("Data row value - " + i + "C");
                obj.Add("Data row value - " + i + "D");
                objNewRecords.Add(obj);
            }
            return objNewRecords;
        }

        private static void UpdatGoogleSheetinBatch(IList<IList<Object>> values, string spreadsheetId, string newRange, SheetsService service)
        {
            SpreadsheetsResource.ValuesResource.AppendRequest request =
               service.Spreadsheets.Values.Append(new ValueRange() { Values = values }, spreadsheetId, newRange);
            request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
            _ = request.Execute();
        }


        //Print data from googlesheet
        public string PrintSheetData(string spreadsheetId, string sData, int columb1, int columb2)
        {
            var service = AuthorizeGoogleAppForSheetsService();
            var newRange = sData;

            SpreadsheetsResource.ValuesResource.GetRequest getRequest = service.Spreadsheets.Values.Get(spreadsheetId, newRange);

            RetrieveData(getRequest, columb1, columb2);

            string data = RetrieveData(getRequest, columb1, columb2);

            return data;
        }


        //Getting row from googlesheet
        private static string RetrieveData(SpreadsheetsResource.ValuesResource.GetRequest request, int columb1, int columb2)
        {
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            string data = "";
            if (values == null || values.Count == 0)
            {
                Console.WriteLine("No data found.");
                return "No data found.";

            }
            else
            {
                foreach (var row in values)
                {
                    string rdata = "";
                    for (var i = columb1;  i < columb2+1 ; i++)
                    {
                         rdata += row[i] + "  ";
                    }

                    rdata += System.Environment.NewLine;
                    data += rdata;
                }

                MessageBox.Show(data);
            }

            

            return data;
        }

        public string Range(string name, string start, string end, decimal startNum, decimal endNum)
        {
            string data = name + "!"+ start + startNum + ":" + end +endNum;
            MessageBox.Show(data);
            return data;
        }
    }
}
