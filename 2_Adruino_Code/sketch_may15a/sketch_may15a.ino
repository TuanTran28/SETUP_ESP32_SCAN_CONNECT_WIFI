
#include "WiFi.h"
#define   CATCH_CMD   35 // character # in ASCII
#define   CATCH_WIFISTATUS  36 // Character $ in ASCII

int sCount = 0;
int isTransfer = 0;
String receive_data = " ";
byte receive_byte = ' ';
String Text_Wifi = "Wifi";

char SSID_String[20];
char SSID_Password[20];
char *pSSID = &SSID_String[0];
char *pPassword = &SSID_Password[0];
void setup()
{
  Serial.begin(115200);
  WiFi.mode(WIFI_STA);
  WiFi.disconnect();
  delay(100);
}

void loop()
{
  
  while(1)
  {
    if (Serial.available())
    {
      receive_byte = Serial.read();
      receive_data += (char)receive_byte;
      if (receive_byte == CATCH_CMD)
      {
        receive_data.trim();
        break;
      }
    }
    else
    {
      receive_data = "";
      break;
    }
  }

  int sLength = receive_data.length();
  /*Character # for end of string*/
  if(receive_data[sLength-1] == '#') 
  {
    if (receive_data == "Scan#")
    {
      int n = WiFi.scanNetworks();
      if (n == 0)
      {
        Serial.println("no networks found");
      }
      else if (isTransfer == 0)
      {
//        Serial.print(n);
//        Serial.println("@");
        for (int i = 0; i < n; ++i)
        {
          // Print SSID and RSSI for each network found
          Serial.print(i + 1);
          Serial.print(": ");
          Serial.print(WiFi.SSID(i));
          Serial.print(" (");
          Serial.print(WiFi.RSSI(i));
          Serial.print(")");
          delay(1000);
        }
        receive_data = "";
      }
    }
    else
    {
      int Flag_SSID =0;
      int Flag_Pass =0;
      int Length_SSID =0;
      int Length_Pass =0;
      for(int m=0; m < sLength;m++)
      {
        switch(receive_data[m])
        {
          case '(':
            Flag_SSID = 1;
            break;
          case ')':
            Flag_SSID = 0;
            break;
          case '[':
            Flag_Pass = 1;
            break;
          case ']':
            Flag_Pass = 0;
            break;
          default:
           if(Flag_SSID)
          {
            SSID_String[Length_SSID] = receive_data[m];
            Length_SSID++;
          }
          if(Flag_Pass)
          {
            SSID_Password[Length_Pass] = receive_data[m];
            Length_Pass++;
          }
            break;          
        }

      }
      memcpy(pSSID,SSID_String,Length_SSID);
      memcpy(pPassword,SSID_Password,Length_Pass);
      Serial.print("$");
      Serial.print(pSSID);
      Serial.print(pPassword);
      receive_data = "";
      WiFi.begin(pSSID,pPassword);
      delay(500);
      int retry = 0;
      Serial.print("$Connecting...");
      delay(2000);
      while (WiFi.status() != WL_CONNECTED) 
      {
        delay(1000);
        retry++;
        if(retry == 10)
        {break;}
      }
      if(retry == 10)
      {Serial.print("$Cant Connected");}
      else
      {
         Serial.print("$Connected");
      }  
      memset(pSSID,0x00,strlen(pSSID));
      memset(pPassword,0x00,strlen(pPassword));
    }
  }
  receive_data = "";
}
