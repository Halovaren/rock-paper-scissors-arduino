//Player 2 - Wemos D1 R32

//#include <ESP8266WiFi.h>
//#include <ESP8266HTTPClient.h>

#include <WiFi.h>
#include <HTTPClient.h>

const char* ssid = "Reesespieces";
const char* password = "kimmmyyy";
const char* host = "172.20.10.2";

//const char* ssid = "Jhay";
//const char* password = "bobobobo";
//const char* host = "172.20.10.3";

//const char* ssid = "PLDTHOMEFIBRfece0";
//const char* password = "PLDTWIFIN0Mys";
//const char* host = "192.168.1.6";

const int ROCK_BTN = D2;
const int PAPER_BTN = D3;
const int SCISSORS_BTN = D4;
const int ONLINE_LED = D5;
const int OFFLINE_LED = D6;

void setup() {
  pinMode(ROCK_BTN, INPUT);
  pinMode(PAPER_BTN, INPUT);
  pinMode(SCISSORS_BTN, INPUT);
  pinMode(OFFLINE_LED,OUTPUT);
  pinMode(ONLINE_LED,OUTPUT);

  Serial.begin(9600);
  Serial.print("Connecting to ");
  Serial.println(ssid);
  WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, password);
   digitalWrite(OFFLINE_LED,1);
    digitalWrite(ONLINE_LED,0);

  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("No Signal..");
    digitalWrite(OFFLINE_LED,1);
    digitalWrite(ONLINE_LED,0);
  }
  digitalWrite(OFFLINE_LED,0);
  digitalWrite(ONLINE_LED,1);
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}

void loop() {
  if(WiFi.status()== WL_CONNECTED){

    digitalWrite(OFFLINE_LED,0);
    digitalWrite(ONLINE_LED,1);

    // Read the state of the buttons
    int rockState1 = digitalRead(ROCK_BTN);
    int paperState1 = digitalRead(PAPER_BTN);
    int scissorsState1 = digitalRead(SCISSORS_BTN);
    #define BTN_DEBOUNCE_DELAY 250

    // Check if the rock button was pressed and released for player 1
    if (rockState1 == HIGH)
    {
      delay(BTN_DEBOUNCE_DELAY); // Debounce delay
      if (digitalRead(ROCK_BTN) == LOW)
      {
      Serial.println("2R");
      UpdateP2Data("2R");
      }
    }

    // Check if the paper button was pressed and released for player 1
    if (paperState1 == HIGH)
    {
      delay(BTN_DEBOUNCE_DELAY); // Debounce delay
      if (digitalRead(PAPER_BTN) == LOW)
      {
        Serial.println("2P");
        UpdateP2Data("2P");
      }
    }

    // Check if the scissors button was pressed and released for player 1
    if (scissorsState1 == HIGH)
    {
      delay(BTN_DEBOUNCE_DELAY); // Debounce delay
      if (digitalRead(SCISSORS_BTN) == LOW)
      {
        Serial.println("2S");
        UpdateP2Data("2S");
      }
    }
  }else
  {
    digitalWrite(OFFLINE_LED,1);
    digitalWrite(ONLINE_LED,0);
  }
}

//execute update query for P1
void UpdateP2Data(String P2choice){
      HTTPClient http;
      WiFiClient wifi;
      http.begin(wifi, "http://172.20.10.2/Mod3RPS/updateP2Data.php?ipsrc=1&P2HandChoice=" + P2choice);
      http.addHeader("Content-Type", "text/plain");
      http.GET();
}