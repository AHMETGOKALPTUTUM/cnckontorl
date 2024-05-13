int veri=0;
int adim;
String karkater;
#define dir1 4
#define step1 3
#define ena1 2
int a;
#define dir2 7
#define step2 6
#define ena2 5
#define zmbrt 9
int x = 500;
void setup(){
  Serial.begin(9600);
   pinMode(dir1, OUTPUT);
  pinMode(step1, OUTPUT);
  pinMode(ena1, OUTPUT);
  pinMode(dir2, OUTPUT);
  pinMode(step2, OUTPUT);
  pinMode(ena2, OUTPUT);
  pinMode(zmbrt, INPUT);
  
  }
  void loop(){
    if (Serial.available()>0){
      veri = Serial.parseInt();
      karkater=Serial.read();
      Serial.println(veri);
      Serial.println(karkater);
      adim=veri;
      if(karkater=="97"){
        ileri();
       
         
      }
      if(karkater=="98"){
       gerii();
        
      }
      if(karkater=="99"){
        sol();
         
         
      }
      if(karkater=="100"){
        sag();
 
        
      }
      }
    }
    void ileri(){
  
  for (int c = 0; c < adim; c++) {
    if(digitalRead(zmbrt)==1){
        Serial.println(adim-c);
        
     Serial.print("ierli gidiyor kalan adım: ");
  
        digitalWrite(step1, 1); //1.motor ileri
        digitalWrite(step1, 0);
        delayMicroseconds(x);
        digitalWrite(dir1, 1);


        digitalWrite(step2, 1); //2.motor ileri
        digitalWrite(step2, 0);
        delayMicroseconds(x);
        digitalWrite(dir2, 1);
       
    }else if(digitalRead(zmbrt)==0){
      c=adim;
      Serial.println("LİMİT!!");
      Serial.println("limite gelindi");
      }
        }
        }
        
void gerii(){
 
    for (int c = 0; c < adim; c++) {
    if(digitalRead(zmbrt)==1){
        Serial.println(adim-c);
        
     Serial.print("geri gidiyor kalan adım: ");
  
        digitalWrite(step1, 1); //1.motor geri
        digitalWrite(step1, 0);
        delayMicroseconds(x);
        digitalWrite(dir1, 0);


        digitalWrite(step2, 1); //2.motor geri
        digitalWrite(step2, 0);
        delayMicroseconds(x);
        digitalWrite(dir2, 0);
       
    }else if(digitalRead(zmbrt)==0){
      c=adim;
      Serial.println("LİMİT!!");
      Serial.println("limite gelindi");
      }
        }

}
void sol(){
  
   for (int c = 0; c < adim; c++) {
    if(digitalRead(zmbrt)==1){
        Serial.println(adim-c);
        
     Serial.print("sol gidiyor kalan adım: ");
  
        digitalWrite(step1, 1); //1.motor geri
        digitalWrite(step1, 0);
        delayMicroseconds(x);
        digitalWrite(dir1, 1);


        digitalWrite(step2, 1); //2.motor geri
        digitalWrite(step2, 0);
        delayMicroseconds(x);
        digitalWrite(dir2, 0);
       
    }else if(digitalRead(zmbrt)==0){
      c=adim;
      Serial.println("LİMİT!!");
      Serial.println("limite gelindi");
      }
        }

}
void sag(){

   for (int c = 0; c < adim; c++) {
    if(digitalRead(zmbrt)==1){
        Serial.println(adim-c);
        
     Serial.print("saga gidiyor kalan adım: ");
  
        digitalWrite(step1, 1); //1.motor geri
        digitalWrite(step1, 0);
        delayMicroseconds(x);
        digitalWrite(dir1, 0);


        digitalWrite(step2, 1); //2.motor geri
        digitalWrite(step2, 0);
        delayMicroseconds(x);
        digitalWrite(dir2, 1);
       
    }else if(digitalRead(zmbrt)==0){
      c=adim;
      Serial.println("LİMİT!!");
      Serial.println("limite gelindi");
      }
        }
  
}
