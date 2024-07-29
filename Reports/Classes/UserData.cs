using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Classes
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public required string Username { get; set; }
        [FirestoreProperty]
        public required string Password { get; set; }
        [FirestoreProperty]
        public required string DBUsername { get; set; }
        [FirestoreProperty]
        public required string DBPassword { get; set; }
        [FirestoreProperty]
        public required string Date { get; set; }

    }
}
