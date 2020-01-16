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
        double targetLat = 0;
        double targetLong = 0;
        double leniencyNum = 0;
        public bool servoOn = false;
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
        private void setAltitude()
        {

            this.altitude = (MainV2.comPort.MAV.cs.alt * 3.28084) - this.calibratedAltitude;
            this.altitudeValue.Text = this.altitude + " ft";
            //this.alt_value.Refresh();

        }
        private void setLatitude()
        {
            this.latitudeValue.Text = MainV2.comPort.MAV.cs.lat + " ft";
            //this.alt_value.Refresh();

        }
        private void setLongitude()
        {
            this.longitudeValue.Text = MainV2.comPort.MAV.cs.lng + " ft";
            //this.alt_value.Refresh();

        }
        private void setAirSpeed()
        {
            this.airSpeedValue.Text = MainV2.comPort.MAV.cs.airspeed + " ft";
            //this.alt_value.Refresh();

        }
        private void setGroundSpeed()
        {
            this.groundSpeedValue.Text = MainV2.comPort.MAV.cs.groundspeed + " ft";
            //this.alt_value.Refresh();

        }
        private void setLeniency()
        {
            try
            {
                leniencyNum = Double.Parse(TargetLeniencyLabel.Text);
            }
            catch (FormatException)
            {


            }
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
        public void update()
        {
            setAltitude();
            setLatitude();
            setLongitude();
            setAirSpeed();
            setGroundSpeed();
            setLeniency();

        }

        private void altitudeCalibration_Click(object sender, EventArgs e)
        {
            calibrateAltitude();
        }
        public Double DistanceWithinTarget()
        {
            double R = 6373.0;

            double lat1 = radians(MainV2.comPort.MAV.cs.lat);
            double lon1 = radians(MainV2.comPort.MAV.cs.lng);
            double lat2 = radians(targetLat);
            double lon2 = radians(targetLong);
            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = R * c;

            return distance;

            //Double latDistance = MainV2.comPort.MAV.cs.lat - targetLat;
            //Double longDistance = MainV2.comPort.MAV.cs.lng  - targetLong;
            //Double targetDistance = Math.Sqrt(Math.Pow(latDistance, 2) + Math.Pow(longDistance, 2));

            //return targetDistance;
        }
        public bool isWithinTarget() {

            return DistanceWithinTarget() <= Double.Parse(TargetLeniencyTextbox.Text);
        }
         
        public void calibrateTarget() {
            targetLat = MainV2.comPort.MAV.cs.lat;
            targetLong = MainV2.comPort.MAV.cs.lng;
        }
        private void calibrateTargetButton_Click(object sender, EventArgs e)
        {
            calibrateTarget();
            TargetCoordinateLabel.Text = targetLat + ", " + targetLong;
        }

        private void SurvoTurnButton_Click(object sender, EventArgs e)
        {

            servoOn = !servoOn;
        }
        private double radians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
