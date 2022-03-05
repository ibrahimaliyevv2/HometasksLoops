using System;

class Programfirst {
  static int findAverage(int m){
    int i=1;
    int count=0;
   int sum=0;
    while(i<=m){
      if(i%15==0 && i!=0){
        sum+=i;
        count++;
        i++;
      }
  else i++;
    }
     int average = sum/count;
    return average;
  }
  
    public static void Main(string[] args) {
      Console.WriteLine("Enter number:");
         int m = Convert.ToInt32(Console.ReadLine());
      int average_num=findAverage(m);
      Console.WriteLine("Answer:"+average_num);
    }
}