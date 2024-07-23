using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Classes
{
    internal static class FireStoreHelper
    {
        static string config = @"
                                {
                                  ""type"": ""service_account"",
                                  ""project_id"": ""pradeepbot-fjvj"",
                                  ""private_key_id"": ""28142c3ba398871377a3accf1d986d0139a266f5"",
                                  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCsKSG4hjq20Riz\nohdOvOjx+JeKF69aNdyDBS9zRGdDd+8tfAyr8j3AyjHYReAf6QNw5j4u7yhOjtgp\njbib5htRgnLIsQXpItjfLwNzTEYGwFrkCHjIkFB9px/l/KVDaviMHqge2piO4t0M\nbUxcHXVgGmzSkotMLUZmTMXyi/oEdsPrs8i+ZU5YKbntc2mkk40cMlEvLrgxY+4z\n1n4QhsYVPlXLAOyiylTqpLPdsO90wasSqHmf9c3P2tG7yKHE95hlT5jKXOvsISQj\nuPdb2QleOA0qYw/59JifHSSRkwE6rTwP/HE/GGwbkU5Ez3aPXZ10PEAyElWxjwQz\nQTsAc90HAgMBAAECggEAAZMov07fB6AXCUGg0/QPb3M2M6muzXTzrPEls3i7NxdI\nRVK+rO382aAf35oYCEKx6Nz6UaSXakyNNqgYubhbpJ28XhCcfLr4X+ZGsk3O0C3/\nRtm6/R6w1c1rEcgDXQAEAQggwpN+VMRHgF8ZlTghxDzJpQ15H7vESphGMUdNhK/r\nkUgnMU82gwiGz807rXZ1HMzSupZXg3bpJoVJX39pndn7r/DMS1KL/JPfAh7SHtTy\nLSHd+DH1OkJEvdA6S5Y0jfLUUe2nqHThTmBvOI7SmPYWvb5B7Fx91cc9wN8bxCv+\n1PJmwUKokmR/oloufkXUUPwHXYyRAXlg/cvnfFmJHQKBgQDtOK0IKpoj511m2sP0\nRVR4eL6CQcGexLydvhh0g7FNoHbZqUvJXqGqtPBO3l1YRaTm27N9DPCV2xFzhIpE\nhrqOJ0Pz7JzVqK8bVUCy9rayU5ItwL01Eu6WQ4EQduOMov63rr2I2epg7CJOH4Yv\n6qP/3ij/pHwMRG+qcR3zPntdFQKBgQC5yf3LsicNTEVzmZr4YmQzD4Q8fzli9Hqk\nL4Yki25LuDTJPeW30ZI4kZNDes8cWZKfB8CiBNpV9/2tm2S/9uzpuRPbM5eySubt\nJ2a3scQdfF6v3xRiARu0GPYqsDPGCLsc2f5XWh0/eUdGqwXfUs//BuAS1BMq4HfC\nTdGZNeXwqwKBgCKsNQZLi8oRqCI/eYK7m3QcWeQaDl3Rbaw0u8hT81dgS97WkuA0\n97ZGyhUNBWHAlDC2Dg8KFCQjJ/LVfYw0kRH0BUei3u2PwUBifplp3BxGgMg1MrKO\nONc3uKaaafoFXOumG8fj6hEOkpkOnINmbWAZra5n8UWtvxCPhgwmpstdAoGBAIdZ\n2dUJQBwXAc37DQSBod/1IPB1+1fVJnfwy3haQAtX8tTdjDrDqhQeMjwJ/1L3CrNj\nEXq3sFzLI3vT5q1Xdje8BvQ9/Pj+SohhmRqgnnCgx9a23YGcrxMg0E4/Oii++ZpG\nUl5PH1m7wCqCs++DxFZWKu5spF4rU/Qxf05wDsmrAoGBAIW/0tULHpM39Yyu8gjC\nQsRHdPia6mOyX4QCNKTeu8TUm78TTpSLg20UgS+ako1HUCtDDOaScC50suBWwWcL\nB1tizKTCQxeiySSgBnFjJtycAmE9UNQ8PvNHTxk4CCvaDZpqYV562PgMNSRWwuIN\nbbHO3rO7BRW7y+KTECDLcAyY\n-----END PRIVATE KEY-----\n"",
                                  ""client_email"": ""firebase-adminsdk-wfwyd@pradeepbot-fjvj.iam.gserviceaccount.com"",
                                  ""client_id"": ""117729268488541819160"",
                                  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
                                  ""token_uri"": ""https://oauth2.googleapis.com/token"",
                                  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
                                  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-wfwyd%40pradeepbot-fjvj.iam.gserviceaccount.com"",
                                  ""universe_domain"": ""googleapis.com""
                                }";
        static string filepath = "";
        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, config);
            File.SetAttributes(filepath,FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS",filepath);
            Database = FirestoreDb.Create("pradeepbot-fjvj");
            File.Delete(filepath);

        }


    }
}
