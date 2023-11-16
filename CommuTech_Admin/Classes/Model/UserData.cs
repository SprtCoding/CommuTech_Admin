using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommuTech_Admin.Classes.Model
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string USER_ID { get; set; }
        [FirestoreProperty]
        public string ACCOUNT_TYPE { get; set; }
        [FirestoreProperty]
        public string ADDRESS { get; set; }
        [FirestoreProperty]
        public string EMAIL_ID { get; set; }
        [FirestoreProperty]
        public string CONTACT_NUMBER { get; set; }
        [FirestoreProperty]
        public string NAME { get; set; }
        [FirestoreProperty]
        public string USERNAME { get; set; }
        [FirestoreProperty]
        public string PASSWORD { get; set; }
        [FirestoreProperty]
        public string PARENTS_NAME { get; set; }
        [FirestoreProperty]
        public string PARENTS_NUMBER { get; set; }
    }
}
