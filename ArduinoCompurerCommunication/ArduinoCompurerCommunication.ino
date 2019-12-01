#include <LiquidCrystal.h>

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";

int led0Pin = 13;
int led1Pin = 12;


boolean isConnected = false;

LiquidCrystal lcd(8,9,4,5,6,7); 


void setup() {

  Serial.begin(9600);
  pinMode(led0Pin,OUTPUT);
  pinMode(led1Pin,OUTPUT);
  
  initDisplay();
}

void loop() {

  if(stringComplete)
  {
    stringComplete = false;
    getCommand();

    if(commandString.equals("STAR"))
    {
      lcd.clear();
    }
    if(commandString.equals("STOP"))
    {
      turnLedOff(led0Pin);
      turnLedOff(led1Pin);
      
      lcd.clear();
      lcd.print("Ready to connect");    
    }
    else if(commandString.equals("TEXT"))
    {
      String text = getTextToPrint();
      printText(text);
    }
    else if(commandString.equals("LED0"))
    {
      boolean LedState = getLedState();
      if(LedState == true)
      {
        turnLedOn(led0Pin);
      }
      else
      {
        turnLedOff(led0Pin);
      }   
    }
    else if(commandString.equals("LED1"))
    {
      boolean LedState = getLedState();
      if(LedState == true)
      {
        turnLedOn(led1Pin);
      }
      else
      {
        turnLedOff(led1Pin);
      }   
    }
    /*else if(commandString.equals("LED3"))
    {
      boolean LedState = getLedState();
      if(LedState == true)
      {
        turnLedOn(led3Pin);
      }
      else
      {
        turnLedOff(led3Pin);
      }   
    }*/

    inputString = "";
  }

}

void initDisplay()
{
  lcd.begin(16, 2);
  lcd.print("Ready to connect");
}

boolean getLedState()
{
  boolean state = false;
  if(inputString.substring(5,7).equals("ON"))
  {
    state = true;
  }
  else
  {
    state = false;
  }
  return state;
}

void getCommand()
{
  if(inputString.length()>0)
  {
    commandString = inputString.substring(1,5);
  }
}

void turnLedOn(int pin)
{
  digitalWrite(pin,HIGH);
}

void turnLedOff(int pin)
{
  digitalWrite(pin,LOW);
}


String getTextToPrint()
{
  String value = inputString.substring(5,inputString.length()-2);
  return value;
}

void printText(String text)
{
  lcd.clear();
  lcd.setCursor(0,0);
  if(text.length()<16)
  {
    lcd.print(text);
  }
  else
  {
    lcd.print(text.substring(0,16));
    lcd.setCursor(0,1);
    lcd.print(text.substring(16,32));
  }
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}


