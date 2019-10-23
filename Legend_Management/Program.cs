//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Sheets.v4;
//using Google.Apis.Sheets.v4.Data;
//using Google.Apis.Services;
//using Google.Apis.Util.Store;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Threading;

//namespace Legend_Management
//{
//    class Program
//    {
//        // If modifying these scopes, delete your previously saved credentials
//        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
//        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
//        static string ApplicationName = "Google Sheets API .NET Quickstart";

//        static void Main(string[] args)
//        {
//            UserCredential credential;

//            using (var stream =
//                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
//            {
//                // The file token.json stores the user's access and refresh tokens, and is created
//                // automatically when the authorization flow completes for the first time.
//                string credPath = "token.json";
//                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
//                    GoogleClientSecrets.Load(stream).Secrets,
//                    Scopes,
//                    "user",
//                    CancellationToken.None,
//                    new FileDataStore(credPath, true)).Result;
//                Console.WriteLine("Credential file saved to: " + credPath);
//            }

//            // Create Google Sheets API service.
//            var service = new SheetsService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = ApplicationName,
//            });

//            // Define request parameters.
//            String spreadsheetId = "1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms";
//            String range = "Class Data!A2:E";
//            SpreadsheetsResource.ValuesResource.GetRequest request =
//                    service.Spreadsheets.Values.Get(spreadsheetId, range);

//            // Prints the names and majors of students in a sample spreadsheet:
//            // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
//            ValueRange response = request.Execute();
//            IList<IList<Object>> values = response.Values;
//            if (values != null && values.Count > 0)
//            {
//                Console.WriteLine("Name, Major");
//                foreach (var row in values)
//                {
//                    // Print columns A and E, which correspond to indices 0 and 4.
//                    Console.WriteLine("{0}, {1}", row[0], row[4]);
//                }
//            }
//            else
//            {
//                Console.WriteLine("No data found.");
//            }
//            Console.Read();
//        }
//    }
//}
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Newtonsoft.Json;
using Google.Apis.Util.Store;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


using Data = Google.Apis.Sheets.v4.Data;

namespace Legend_Management
{
    public class Program
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        public static void Main(string[] args)
        {
            //Moderator meg = new Moderator();
            //meg.AddLegend();
            //Console.WriteLine("done");
            //Console.ReadLine();
            SheetsService sheetsService = new SheetsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = GetCredential(),
                ApplicationName = "Google-SheetsSample/0.1",
            });

            // TODO: Assign values to desired properties of `requestBody`:
            Data.Spreadsheet requestBody = new Data.Spreadsheet();

            SpreadsheetsResource.CreateRequest request = sheetsService.Spreadsheets.Create(requestBody);

            // To execute asynchronously in an async method, replace `request.Execute()` as shown:
            Data.Spreadsheet response = request.Execute();
            // Data.Spreadsheet response = await request.ExecuteAsync();

            // TODO: Change code below to process the `response` object:
            Console.WriteLine(JsonConvert.SerializeObject(response
            //SheetsService sheetsService = new SheetsService(new BaseClientService.Initializer
            //{
            //    HttpClientInitializer = GetCredential(),
            //    ApplicationName = "Google-SheetsSample/0.1",
            //});

            //// TODO: Assign values to desired properties of `requestBody`:
            //Data.Spreadsheet requestBody = new Data.Spreadsheet();

            //SpreadsheetsResource.CreateRequest request = sheetsService.Spreadsheets.Create(requestBody);

            //// To execute asynchronously in an async method, replace `request.Execute()` as shown:
            ////Data.Spreadsheet response = request.Execute();
            // Data.Spreadsheet response = await request.ExecuteAsync();

            //// TODO: Change code below to process the `response` object:
            //Console.WriteLine(JsonConvert.SerializeObject(response));
        }

        public static UserCredential GetCredential()
        {
            // TODO: Change placeholder below to generate authentication credentials. See:
            // https://developers.google.com/sheets/quickstart/dotnet#step_3_set_up_the_sample
            //
            // Authorize using one of the following scopes:
            //     "https://www.googleapis.com/auth/drive"
            //     "https://www.googleapis.com/auth/drive.file"
            //     "https://www.googleapis.com/auth/spreadsheets"
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
            return credential;
        }
    }
}

