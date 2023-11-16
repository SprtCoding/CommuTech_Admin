using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommuTech_Admin.Classes.Model
{
    [FirestoreData]
    internal class RecordsData
    {
        [FirestoreProperty]
        public string ID { get; set; }
        [FirestoreProperty]
        public string STUDENT_NAME { get; set; }
        [FirestoreProperty]
        public string DRIVER_NAME { get; set; }
        [FirestoreProperty]
        public string LOCATION { get; set; }
        [FirestoreProperty]
        public string DRIVER_FRANCHISE_NO { get; set; }
        [FirestoreProperty]
        public string DRIVER_LICENSE { get; set; }
        [FirestoreProperty]
        public string DRIVER_REG_NO { get; set; }
        [FirestoreProperty]
        public string SMS_TYPE { get; set; }
        [FirestoreProperty]
        public string DATE { get; set; }
        [FirestoreProperty]
        public string TIME { get; set; }
    }
}
