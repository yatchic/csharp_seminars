 

int sumIntDigits(int dig){
int digits=dig;
int rest=0;
 if(digits<10&&digits>-10){
   return digits;}
    else{ 
    if(digits<0){digits=digits*-1;}
    
    rest=digits%10;
   
   while(digits>0){
  digits=digits/10;
   if(digits>0){   rest=rest+digits%10;     }else{return rest;}

 }
 
}

return 0;

}
int enter(){
  while(true){
    string q = Console.ReadLine(); 
  if(q=="q"){Console.WriteLine("выход");return 0;}
int num = int.Parse(Console.ReadLine()!); 
int dig=sumIntDigits(num);
if(dig%2==0){Console.WriteLine($"четное число={dig}");return 0;}

}

}

enter();