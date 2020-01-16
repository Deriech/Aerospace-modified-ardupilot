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
WithinLen = False;
# A rough estimate of deg to m: 1 deg = 111,111 m (111.111 km)
while(True):
	DAS.update();
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
	if(not WithinLen) and (DAS.isWithinTarget):
		print 'Payload is within target Range'
		WithinLen = True;
	if (DAS.servoOn):
    		Script.SendRC(8,1900,True);
	else:
        	Script.SendRC(8,1100,True);

	#time.sleep(0.1);
