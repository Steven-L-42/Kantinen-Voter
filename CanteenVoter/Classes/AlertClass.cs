using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenVoter
{
    public class AlertClass
    {
        public static void Show(string msg, Alert.enmType type = Alert.enmType.Success)
        {
            Alert frm = new Alert();
            frm.TopMost = true;
            frm.showAlert(msg, type);
        }
    }

}
