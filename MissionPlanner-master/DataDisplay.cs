using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//added so we can print to console
using System.Diagnostics;

/* We had two DataDisplay classes accidentally which is why we didn't see any changes being made
 * This the ACTUAL DataDisplay class we should be working on
 * */
namespace MissionPlanner
{
    public partial class DataDisplay : Form
    {
        double altitude = 0;
        double bottleAltitude = 0;
        double pongAltitude = 0;
        double calibratedAltitude = 0;

        public DataDisplay()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

        }
        /*
         *Updates: Figured out why display wasn't updating
         * There were actually two DataDisplays being created one was shown (.show()) the other one wasn't
         * The one visible was the one created where the console was made, BUT the one that would be visible
         * to ironpython was the one created in the scope.
         */

        /* public void setAltitude(double alt)
   {
       var timenow = DateTime.Now;
       if ((DateTime.Now - dt).Milliseconds <= 500)
           return;
           synchronizationContext.Post(new SendOrPostCallback(o => {
               this.alt_value.Text = "" + (double) o;
           }), alt);
       dt = timenow;
   }


   public async void updateAltitude(double alt)
   {
       await Task.Run(() =>
       {
           setAltitude(alt);
       });
   }*/  public void calibrateAltitude()
        {
            this.calibratedAltitude = MainV2.comPort.MAV.cs.alt * 3.28084;
        }
        public void setAltitude(double alt)
        {

            this.altitude = alt - this.calibratedAltitude;
            this.altitudeValue.Text = this.altitude + " ft";
            //this.alt_value.Refresh();

        }
        public void setLatitude(double lat)
        {
            this.latitudeValue.Text = lat + " ft";
            //this.alt_value.Refresh();

        }
        public void setLongitude(double lon)
        {
            this.longitudeValue.Text = lon + " ft";
            //this.alt_value.Refresh();

        }
        public void setAirSpeed(double air)
        {
            this.airSpeedValue.Text = air + " ft";
            //this.alt_value.Refresh();

        }
        public void setGroundSpeed(double gnd)
        {
            this.groundSpeedValue.Text = gnd + " ft";
            //this.alt_value.Refresh();

        }
        //Method for time stamping payload drop will problably have two separate methods for each type
        public void recordPingDrop()
        {
            this.pongAltitude = this.altitude;
            this.cdaAltitudeValue.Text = this.pongAltitude + " ft";
            this.pingIndicatorIcon.BackColor = Color.FromArgb(255, 0, 255, 0);

        }
        public void recordWaterDrop()
        {
            this.bottleAltitude = this.altitude;
            this.payloadAltitudeValue.Text = this.bottleAltitude + " ft";
            this.waterIndicatorIcon.BackColor = Color.FromArgb(255, 0, 255, 0);
        }
        //Should we use one method to update all of the data recorded and make the other methods private?
        private void update()
        {

        }

        private void altitudeCalibration_Click(object sender, EventArgs e)
        {
            calibrateAltitude();
        }

        private void longitudeLabel_Click(object sender, EventArgs e)
        {

        }

        private void DataDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
