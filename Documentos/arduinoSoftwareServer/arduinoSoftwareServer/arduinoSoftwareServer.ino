#include <SPI.h>
#include <Ethernet.h>
#include <ArduinoRS485.h> 
#include <ArduinoModbus.h>

byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };
IPAddress ip(192, 168, 1, 10);

EthernetServer ethServer(502);

ModbusTCPServer modbusTCPServer;

int PinA0 = A0; int PinA1 = A1; int PinA2 = A2; int PinA3 = A3; int PinA4 = A4; int PinA5 = A5; int PinA6 = A6; int PinA7 = A7; 
int PinA8 = A8; int PinA9 = A9; int PinA10 = A10; int PinA11 = A11; int PinA12 = A12; int PinA13 = A13; int PinA14 = A14; int PinA15 = A15;

int Pin2 = 2; int Pin3 = 3; int Pin4 = 4; int Pin5 = 5; int Pin6 = 6; int Pin7 = 7; int Pin8 = 8; int Pin9 = 9;
int Pin22 = 22; int Pin23 = 23; int Pin24 = 24; int Pin25 = 25; int Pin26 = 26; int Pin27 = 27; int Pin28 = 28;
int Pin29 = 29; int Pin30 = 30; int Pin31 = 31; int Pin32 = 32; int Pin33 = 33; int Pin34 = 34; int Pin35 = 35;
int Pin36 = 36; int Pin37 = 37; int Pin38 = 38; int Pin39 = 39; int Pin40 = 40; int Pin41 = 41; int Pin42 = 42;
int Pin43 = 43; int Pin44 = 44; int Pin45 = 45; int Pin46 = 46; int Pin47 = 47; int Pin48 = 48; int Pin49 = 49;
int Pin50 = 50; int Pin51 = 51; 

unsigned long duracao;

void setup() {
  
  // start the Ethernet connection and the server:
  Ethernet.begin(mac, ip);
    
  ethServer.begin();
  
  // start the Modbus TCP server
  if (!modbusTCPServer.begin()) {
    Serial.println("Failed to start Modbus TCP Server!");
    while (1);
  }

  pinMode(PinA0, OUTPUT); pinMode(PinA1, OUTPUT); pinMode(PinA2, OUTPUT); pinMode(PinA3, OUTPUT); pinMode(PinA4, OUTPUT);
  pinMode(PinA5, OUTPUT); pinMode(PinA6, OUTPUT); pinMode(PinA7, OUTPUT); pinMode(PinA8, OUTPUT); pinMode(PinA9, OUTPUT);
  pinMode(PinA10, OUTPUT); pinMode(PinA11, OUTPUT); pinMode(PinA12, OUTPUT); pinMode(PinA13, OUTPUT); pinMode(PinA14, OUTPUT);
  pinMode(PinA15, OUTPUT);
  
  pinMode(Pin2, OUTPUT); pinMode(Pin3, OUTPUT); pinMode(Pin4, OUTPUT); pinMode(Pin5, OUTPUT); pinMode(Pin6, OUTPUT);
  pinMode(Pin7, OUTPUT); pinMode(Pin8, OUTPUT); pinMode(Pin9, OUTPUT);

  pinMode(Pin22, OUTPUT); pinMode(Pin23, OUTPUT); pinMode(Pin24, OUTPUT); pinMode(Pin25, OUTPUT); pinMode(Pin26, OUTPUT);
  pinMode(Pin27, OUTPUT); pinMode(Pin28, OUTPUT); pinMode(Pin29, OUTPUT); pinMode(Pin30, OUTPUT); pinMode(Pin31, OUTPUT);  
  pinMode(Pin32, OUTPUT); pinMode(Pin33, OUTPUT); pinMode(Pin34, OUTPUT); pinMode(Pin35, OUTPUT); pinMode(Pin36, OUTPUT);  
  pinMode(Pin37, OUTPUT); pinMode(Pin38, OUTPUT); pinMode(Pin39, OUTPUT); pinMode(Pin40, OUTPUT); pinMode(Pin41, OUTPUT);
  pinMode(Pin42, OUTPUT); pinMode(Pin43, OUTPUT); pinMode(Pin44, OUTPUT); pinMode(Pin45, OUTPUT); pinMode(Pin46, OUTPUT);
  pinMode(Pin47, OUTPUT); pinMode(Pin48, OUTPUT); pinMode(Pin49, OUTPUT); pinMode(Pin50, OUTPUT); pinMode(Pin51, OUTPUT);   

  analogWrite(PinA0, 0); analogWrite(PinA1, 0); analogWrite(PinA2, 0); analogWrite(PinA3, 0); analogWrite(PinA4, 0); analogWrite(PinA5, 0);
  analogWrite(PinA6, 0); analogWrite(PinA7, 0); analogWrite(PinA8, 0); analogWrite(PinA9, 0); analogWrite(PinA10, 0); analogWrite(PinA11, 0);
  analogWrite(PinA12, 0); analogWrite(PinA13, 0); analogWrite(PinA14, 0);

  digitalWrite(Pin2, HIGH); digitalWrite(Pin3, HIGH); digitalWrite(Pin4, HIGH); digitalWrite(Pin5, HIGH); digitalWrite(Pin6, HIGH);
  digitalWrite(Pin7, HIGH); digitalWrite(Pin8, HIGH); digitalWrite(Pin9, HIGH);
  
  digitalWrite(Pin22, HIGH); digitalWrite(Pin23, HIGH); digitalWrite(Pin24, HIGH); digitalWrite(Pin25, HIGH); digitalWrite(Pin26, HIGH);
  digitalWrite(Pin27, HIGH); digitalWrite(Pin28, HIGH); digitalWrite(Pin29, HIGH); digitalWrite(Pin30, HIGH); digitalWrite(Pin31, HIGH);
  digitalWrite(Pin32, HIGH); digitalWrite(Pin33, HIGH); digitalWrite(Pin34, HIGH); digitalWrite(Pin35, HIGH); digitalWrite(Pin36, HIGH);
  digitalWrite(Pin37, HIGH); digitalWrite(Pin38, HIGH); digitalWrite(Pin39, HIGH); digitalWrite(Pin40, HIGH); digitalWrite(Pin41, HIGH);
  digitalWrite(Pin42, HIGH); digitalWrite(Pin43, HIGH); digitalWrite(Pin44, HIGH); digitalWrite(Pin45, HIGH); digitalWrite(Pin46, HIGH);
  digitalWrite(Pin47, HIGH); digitalWrite(Pin48, HIGH); digitalWrite(Pin49, HIGH); digitalWrite(Pin50, HIGH); digitalWrite(Pin51, HIGH);
  
  modbusTCPServer.configureCoils(0x00, 54);
}

void loop() {

  EthernetClient client = ethServer.available();

  if (client) {
    
    modbusTCPServer.accept(client);

    while (client.connected()) {

      modbusTCPServer.poll();

      if(modbusTCPServer.coilRead(0x00)){ analogWrite(PinA0, 0);}else{analogWrite(PinA0, 255);}//0
      if(modbusTCPServer.coilRead(0x01)){ analogWrite(PinA1, 0);}else{analogWrite(PinA1, 255);}//1
      if(modbusTCPServer.coilRead(0x02)){ analogWrite(PinA2, 0);}else{analogWrite(PinA2, 255);}//2
      if(modbusTCPServer.coilRead(0x03)){ analogWrite(PinA3, 0);}else{analogWrite(PinA3, 255);}//3
      if(modbusTCPServer.coilRead(0x04)){ analogWrite(PinA4, 0);}else{analogWrite(PinA4, 255);}//4
      if(modbusTCPServer.coilRead(0x05)){ analogWrite(PinA5, 0);}else{analogWrite(PinA5, 255);}//5
      if(modbusTCPServer.coilRead(0x06)){ analogWrite(PinA6, 0);}else{analogWrite(PinA6, 255);}//6
      if(modbusTCPServer.coilRead(0x07)){ analogWrite(PinA7, 0);}else{analogWrite(PinA7, 255);}//7
      if(modbusTCPServer.coilRead(0x08)){ analogWrite(PinA8, 0);}else{analogWrite(PinA8, 255);}//8
      if(modbusTCPServer.coilRead(0x09)){ analogWrite(PinA9, 0);}else{analogWrite(PinA9, 255);}//9
      if(modbusTCPServer.coilRead(0x0A)){ analogWrite(PinA10, 0);}else{analogWrite(PinA10, 255);}//10
      if(modbusTCPServer.coilRead(0x0B)){ analogWrite(PinA11, 0);}else{analogWrite(PinA11, 255);}//11
      if(modbusTCPServer.coilRead(0x0C)){ analogWrite(PinA12, 0);}else{analogWrite(PinA12, 255);}//12
      if(modbusTCPServer.coilRead(0x0D)){ analogWrite(PinA13, 0);}else{analogWrite(PinA13, 255);}//13
      if(modbusTCPServer.coilRead(0x0E)){ analogWrite(PinA14, 0);}else{analogWrite(PinA14, 255);}//14
      if(modbusTCPServer.coilRead(0x0F)){ analogWrite(PinA15, 0);}else{analogWrite(PinA15, 255);}//15

      if(modbusTCPServer.coilRead(0x10)){ digitalWrite(Pin2, LOW);}else{digitalWrite(Pin2, HIGH);}//16
      if(modbusTCPServer.coilRead(0x11)){ digitalWrite(Pin3, LOW);}else{digitalWrite(Pin3, HIGH);}//17
      if(modbusTCPServer.coilRead(0x12)){ digitalWrite(Pin4, LOW);}else{digitalWrite(Pin4, HIGH);}//18
      if(modbusTCPServer.coilRead(0x13)){ digitalWrite(Pin5, LOW);}else{digitalWrite(Pin5, HIGH);}//19
      if(modbusTCPServer.coilRead(0x14)){ digitalWrite(Pin6, LOW);}else{digitalWrite(Pin6, HIGH);}//20
      if(modbusTCPServer.coilRead(0x15)){ digitalWrite(Pin7, LOW);}else{digitalWrite(Pin7, HIGH);}//21
      if(modbusTCPServer.coilRead(0x16)){ digitalWrite(Pin8, LOW);}else{digitalWrite(Pin8, HIGH);}//22
      if(modbusTCPServer.coilRead(0x17)){ digitalWrite(Pin9, LOW);}else{digitalWrite(Pin9, HIGH);}//23
     
      if(modbusTCPServer.coilRead(0x18)){ digitalWrite(Pin22, LOW);}else{digitalWrite(Pin22, HIGH);}//24
      if(modbusTCPServer.coilRead(0x19)){ digitalWrite(Pin23, LOW);}else{digitalWrite(Pin23, HIGH);}//25
      if(modbusTCPServer.coilRead(0x1A)){ digitalWrite(Pin24, LOW);}else{digitalWrite(Pin24, HIGH);}//26
      if(modbusTCPServer.coilRead(0x1B)){ digitalWrite(Pin25, LOW);}else{digitalWrite(Pin25, HIGH);}//27
      if(modbusTCPServer.coilRead(0x1C)){ digitalWrite(Pin26, LOW);}else{digitalWrite(Pin26, HIGH);}//28
      if(modbusTCPServer.coilRead(0x1D)){ digitalWrite(Pin27, LOW);}else{digitalWrite(Pin27, HIGH);}//29
      if(modbusTCPServer.coilRead(0x1E)){ digitalWrite(Pin28, LOW);}else{digitalWrite(Pin28, HIGH);}//30
      if(modbusTCPServer.coilRead(0x1F)){ digitalWrite(Pin29, LOW);}else{digitalWrite(Pin29, HIGH);}//31
      if(modbusTCPServer.coilRead(0x20)){ digitalWrite(Pin30, LOW);}else{digitalWrite(Pin30, HIGH);}//32
      if(modbusTCPServer.coilRead(0x21)){ digitalWrite(Pin31, LOW);}else{digitalWrite(Pin31, HIGH);}//33
      if(modbusTCPServer.coilRead(0x22)){ digitalWrite(Pin32, LOW);}else{digitalWrite(Pin32, HIGH);}//34
      if(modbusTCPServer.coilRead(0x23)){ digitalWrite(Pin33, LOW);}else{digitalWrite(Pin33, HIGH);}//35
      if(modbusTCPServer.coilRead(0x24)){ digitalWrite(Pin34, LOW);}else{digitalWrite(Pin34, HIGH);}//36
      if(modbusTCPServer.coilRead(0x25)){ digitalWrite(Pin35, LOW);}else{digitalWrite(Pin35, HIGH);}//37
      if(modbusTCPServer.coilRead(0x26)){ digitalWrite(Pin36, LOW);}else{digitalWrite(Pin36, HIGH);}//38
      if(modbusTCPServer.coilRead(0x27)){ digitalWrite(Pin37, LOW);}else{digitalWrite(Pin37, HIGH);}//39
      if(modbusTCPServer.coilRead(0x28)){ digitalWrite(Pin38, LOW);}else{digitalWrite(Pin38, HIGH);}//40
      if(modbusTCPServer.coilRead(0x29)){ digitalWrite(Pin39, LOW);}else{digitalWrite(Pin39, HIGH);}//41
      if(modbusTCPServer.coilRead(0x2A)){ digitalWrite(Pin40, LOW);}else{digitalWrite(Pin40, HIGH);}//42
      if(modbusTCPServer.coilRead(0x2B)){ digitalWrite(Pin41, LOW);}else{digitalWrite(Pin41, HIGH);}//43
      if(modbusTCPServer.coilRead(0x2C)){ digitalWrite(Pin42, LOW);}else{digitalWrite(Pin42, HIGH);}//44
      if(modbusTCPServer.coilRead(0x2D)){ digitalWrite(Pin43, LOW);}else{digitalWrite(Pin43, HIGH);}//45
      if(modbusTCPServer.coilRead(0x2E)){ digitalWrite(Pin44, LOW);}else{digitalWrite(Pin44, HIGH);}//46
      if(modbusTCPServer.coilRead(0x2F)){ digitalWrite(Pin45, LOW);}else{digitalWrite(Pin45, HIGH);}//47
      if(modbusTCPServer.coilRead(0x30)){ digitalWrite(Pin46, LOW);}else{digitalWrite(Pin46, HIGH);}//48
      if(modbusTCPServer.coilRead(0x31)){ digitalWrite(Pin47, LOW);}else{digitalWrite(Pin47, HIGH);}//49
      if(modbusTCPServer.coilRead(0x32)){ digitalWrite(Pin48, LOW);}else{digitalWrite(Pin48, HIGH);}//50
      if(modbusTCPServer.coilRead(0x33)){ digitalWrite(Pin49, LOW);}else{digitalWrite(Pin49, HIGH);}//51
      if(modbusTCPServer.coilRead(0x34)){ digitalWrite(Pin50, LOW);}else{digitalWrite(Pin50, HIGH);}//52
      if(modbusTCPServer.coilRead(0x35)){ digitalWrite(Pin51, LOW);}else{digitalWrite(Pin51, HIGH);}//53
  }

 }

}
