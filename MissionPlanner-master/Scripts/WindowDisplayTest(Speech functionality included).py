import sys
import time
import MissionPlanner
import clr
clr.AddReference("MissionPlanner")
clr.AddReference("MissionPlanner.Utilities") # includes the Utilities class
#MissionPlanner.MainV2.speechEnable = True
print 'Start Script'

'''Fancy Speech functoinality?

MissionPlanner.MainV2.speechEnable = True
MissionPlanner.MainV2.speechEngine.SpeakAsync("Water Bottles Released at 98.3 feet")
'''
dropWater = False
dropPing = False;
isCalibrated = False;
pingServo = 0;
waterServo = 0;
calibrateServo = 0;

while(True):
	DAS.setAltitude(round((cs.altasl2 * 3.28084),9));
	DAS.setLongitude(round((cs.lng * 3.28084),9));
	DAS.setLatitude(round((cs.lat * 3.28084),9));
	DAS.setAirSpeed(round((cs.airspeed * 3.28084),9));
	DAS.setGroundSpeed(round((cs.groundspeed * 3.28084),9));
	pingServo = cs.ch6in;
	waterServo = cs.ch7in;
	if (not dropPing) and (pingServo<1000):
		print 'CDA released'
		dropPing = True;
		MissionPlanner.MainV2.speechEngine.SpeakAsync("CDA released")
		DAS.recordPingDrop();
	if (not dropWater) and (waterServo>1000):
		print 'Payload bay released'
		dropWater = True;
		MissionPlanner.MainV2.speechEngine.SpeakAsync("Payload bay released")
		DAS.recordWaterDrop();
	#time.sleep(0.1);

