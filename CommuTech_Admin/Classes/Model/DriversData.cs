using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommuTech_Admin.Classes.Model
{
    [FirestoreData]
    internal class DriversData
    {
        [FirestoreProperty]
        public string ID { get; set; }
        [FirestoreProperty]
        public string DRIVERS_NAME { get; set; }
        [FirestoreProperty]
        public string ADDRESS { get; set; }
        [FirestoreProperty]
        public string CONTACT { get; set; }
        [FirestoreProperty]
        public string FRANCHISE_NO { get; set; }
        [FirestoreProperty]
        public string LICENSE_NO { get; set; }
        [FirestoreProperty]
        public string REG_NO { get; set; }
        [FirestoreProperty]
        public string QR_PHOTO { get; set; }
        [FirestoreProperty]
        public string DRIVER_PHOTO { get; set; }
    }
}
