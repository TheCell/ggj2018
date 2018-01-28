# Your code goes here..
myLight = new Light
	color: "#AFA"
	intensity: 1.9
	position: "-1 1 0"

myLight = new Light
	type: Light.point
	color: "#cadd4b"
	intensity: 0.2
	position: "-2 5 10"
	castShadow: yes

Hologram.cursor.enabled = true;
Hologram.cursor.fuse = true;
Hologram.cursor.fuseTimeout = 1.0;
  
tempInput = "";
password = "440";

boxOK.onFusing -> print "nr ok progress"
boxOK.onClick -> 
  print "OK clicked";
  if (password == tempInput)
    print "win";
    ende1.visible = true;
    ende2.visible = true;
    ende3.visible = true;
    ende4.visible = true;
    
  else
    tempInput = "wrong";
    escapeCode.text = tempInput;

boxc.onFusing -> print "nr c progress"
boxc.onClick -> 
  print "c clicked";
  tempInput = "";
  escapeCode.text = tempInput;

box0.onFusing -> print "nr 0 progress"
box0.onClick -> 
  print "0 clicked";
  tempInput += "0";
  escapeCode.text = tempInput;

box1.onFusing -> print "nr 1 progress"
box1.onClick -> 
  print "1 clicked";
  tempInput += "1";
  escapeCode.text = tempInput;

box2.onFusing -> print "nr 2 progress"
box2.onClick -> 
  print "2 clicked";
  tempInput += "2";
  escapeCode.text = tempInput;

box3.onFusing -> print "nr 3 progress"
box3.onClick -> 
  print "3 clicked";
  tempInput += "3";
  escapeCode.text = tempInput;

box4.onFusing -> print "nr 4 progress"
box4.onClick -> 
  print "4 clicked";
  tempInput += "4";
  escapeCode.text = tempInput;

box5.onFusing -> print "nr 5 progress"
box5.onClick -> 
  print "5 clicked";
  tempInput += "5";
  escapeCode.text = tempInput;

box6.onFusing -> print "nr 6 progress"
box6.onClick -> 
  print "6 clicked";
  tempInput += "6";
  escapeCode.text = tempInput;

box7.onFusing -> print "nr 7 progress"
box7.onClick -> 
  print "7 clicked";
  tempInput += "7";
  escapeCode.text = tempInput;

box8.onFusing -> print "nr 8 progress"
box8.onClick -> 
  print "8 clicked";
  tempInput += "8";
  escapeCode.text = tempInput;

box9.onFusing -> print "nr 9 progress"
box9.onClick -> 
  print "9 clicked";
  tempInput += "9";
  escapeCode.text = tempInput;