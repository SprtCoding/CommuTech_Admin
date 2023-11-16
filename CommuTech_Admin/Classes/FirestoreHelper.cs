using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommuTech_Admin.Classes
{
    internal class FirestoreHelper
    {
        static string fireconfig = @"
            {
              ""type"": ""service_account"",
                ""project_id"": ""commutech-de260"",
                ""private_key_id"": ""57a58b8080906d5e716939ec799bb70d1ca56e8e"",
                ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEuwIBADANBgkqhkiG9w0BAQEFAASCBKUwggShAgEAAoIBAQDP8WnWezlWE20o\nP/z3ZmTx0/+TzjT2LywtUE7wU5tYenfLuhTI5tNk3srHghNYJKmKYfKjja7zplMI\nfFuEiicHRARp2dbG2Gr4/uld9smiUDofJxAa50vNxGFoo0W0CIRzzg8lIK38ujLp\nbqzV6t9H8arzUWdQnDoTpLmkVOl7MBQrZYxDRqmfr8Qt2JGYB2N2Jd9toU3QkVyQ\npoISEJGU2aaix7H3Zf5XBeaUCKcplP9CktGcwudnV7nEZEkvLdh7f4Ip4JRQomVC\nAUkV/zaDmFkzrLvHyMAUiNiPpG7HUeVDJZ/RU0nl8JGodfB6T4N97jbObRLjC7ha\nf12jgaGpAgMBAAECgf8TAshbFpObLIDUZBFtT/VMJqHPeexFQEfDk6ZOj26eTMTL\nmFYRLI9X1CsjjDSmQfDENgupnx/HMvnF609+1Kiwmb4vE82teKHVIdqJYT17q7Vz\n2oYGCAcEnj7b3lqfgqG99KUAG2RfBePepFH4GCWa1djFHOL5vrxr9vKgbvImk+nV\n5pqqJhOn/GTzB7OgQ9q7KsMta6Jb3Agp4sxRMIXNtgIsXhSreyxrmyGpztZ0brle\nF/+gU93cGmbidQn6pZjExZV+1LEvEDoBnRvl/ogR7h57EjaZ1FcbcTiOpbutRB/Y\n1blIn8DXiLXYpKQHrwHIihy/HK4LizPjYQ9J65cCgYEA6jvFGUtQHa17yL2ammzl\nbtw/0rFmtZOvtzipcyMbydkooEw+WQX4IDGVDMLkeiEqAFpGZ/eiH6D9EdKZu1Oa\n7YTMWvLUApyrP0+XcksXdYu/ATlKO5cHuuNgmS6RW0dzGesFb4ltdL2Ayx8ExrLS\n/G75GpwOcOwbF/NZljOjgBMCgYEA40Q22q8kWG6FuXovCDYslhud+2zhxA9gG1Mo\ncooLoHvvf+vQyldcTzUiaoifm3HMyFIzkv191JHRadYqL3+xmZfHhCEQPz9dLHoF\nGEmlVHKrQ1ZRiLnKx2HkVUK+IFwzQ3dNP+l3Ac2HrxsPpSaj9+yX+hPKNoM1Rf9i\nPzha5tMCgYBZcONNSk3YV0NaHtRnPUfKsj2ItYbztOY2/2Ls/S4CQHLb6uEv2zCp\nEmXIzq6x1/IS2mXiE1QL4cxgvttHBaC2K6xg2jKMoMhfT4QT94qIrwkLbZXj9ULV\nYTekpnyIr1rLPcwAkCiEmEwSw9BuEyCvlax3Nbnp8q5R0fGWgjdfkwKBgQCjAWRO\nydxJyUwE0sw1GZY1PC2+DkSIOXb3Ylfaf4UDYKFRoTQqTSqabUP4IXJJLgBxlfQD\n8+lys/v962xqkS4zOhgSfxyGIM6Vfhd1ai05Ot33+EuWw5vcEiyRssNntnnWZBV2\nR9/h3Sb6w3AfRm3I/1uqNNOO8eEeCaTQL32TnQKBgBjjpdO7jW0nWOEHq5y7IkIH\nCj1yuuIqvGCtvLy/47ZmXmO6vjbEocjk/+54yNPa6tnYaLsb+B5ROd9aTSdy4Hif\nfM+QWtTnxAYrizyiWthBcydBEhU/ehT9+5WxR5uXq40BkWxH4CA8NLzMS4CdWsHn\nSkCjgIgEFT4MzXDgIO83\n-----END PRIVATE KEY-----\n"",
                ""client_email"": ""firebase-adminsdk-j47uj@commutech-de260.iam.gserviceaccount.com"",
                ""client_id"": ""115100564818020100823"",
                ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
                ""token_uri"": ""https://oauth2.googleapis.com/token"",
                ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
                ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-j47uj%40commutech-de260.iam.gserviceaccount.com"",
                ""universe_domain"": ""googleapis.com""
            }
        ";

        static string filepath = "";
        public static FirestoreDb? database { get; set; }

        public static void SetEnviroonmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            database = FirestoreDb.Create("commutech-de260");
            File.Delete(filepath);
        }

    }
}
