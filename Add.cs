using System;
using System.Text.RegularExpressions;
// class Employee{
//     public string EmName{get;set;}
//     public DateTime DateOfJoing{get;set;}

//     public double ExperienceYears{get;set;}
//     public double ExperienceMonths{get;set;}
// }
class Add{
    public static void Main(){
    //     Add ex1=new Add();
    //     int a = Convert.ToInt32(Console.ReadLine());
    //     int b = Convert.ToInt32(Console.ReadLine());
    //     ex1.Addition(a,b);
    // }
    // public void Addition(int a, int b){
    //     Console.WriteLine(a+b);
    // DateTime dat=DateTime.Parse("2000-05-17 03:55:55.999 am");
    // Console.WriteLine(dat.ToString());
    // Console.WriteLine(dat.Day);
    // Console.WriteLine(dat.Month);
    // Console.WriteLine(dat.Year);
    // Console.WriteLine(dat.Hour);
    // Console.WriteLine(dat.Minute);
    // Console.WriteLine(dat.Second);
    // Console.WriteLine(dat.Millisecond);
    // Console.WriteLine(dat.DayOfWeek);
    // Console.WriteLine(dat.DayOfYear);
    // Console.WriteLine((int)dat.DayOfWeek);
    // DateTime dt=DateTime.Now;
    // Console.WriteLine(dt.ToString());
    // Console.WriteLine(dat.ToShortDateString());
    // Console.WriteLine(dat.ToLongDateString());
    // Console.WriteLine(dat.ToShortTimeString());
    // Console.WriteLine(dat.ToLongTimeString);
    // Console.WriteLine(dat.ToLocalTime());
    // Console.WriteLine(DateTime.DaysInMonth(2022,7));
    // Employee emp=new Employee(){EmName="Subani",DateOfJoing=DateTime.Parse("2015-01-01")};
    // DateTime today=DateTime.Now;
    // if(today.CompareTo(emp.DateOfJoing)==1){
    //     TimeSpan ts=today.Subtract(emp.DateOfJoing);
    //     Console.WriteLine(ts.TotalDays);
    //     emp.ExperienceYears=Math.Floor(ts.TotalDays/365);
    //     Console.WriteLine(emp.ExperienceYears);
    //     // Console.WriteLine(Math.Floor(emp.ExperienceYears));
    //     emp.ExperienceMonths=Math.Floor((ts.TotalDays-Convert.ToInt32(emp.ExperienceYears*365))/30);
    //     Console.WriteLine(emp.ExperienceMonths);
    //     Console.WriteLine(emp.EmName+" has "+emp.ExperienceYears+" Year "+emp.ExperienceMonths+" months of Experience.");


    // }
    // else{
    //     Console.WriteLine("Joining date is greater than today date");
    // }
    // DateTime ad=emp.DateOfJoing.AddDays(10);
    // Console.WriteLine(ad);
    // DateTime su=emp.DateOfJoing.AddDays(-10);
    // Console.WriteLine(su);
    // DateTime mo=emp.DateOfJoing.AddMonths(10);
    // Console.WriteLine(mo);
    // DateTime ye=emp.DateOfJoing.AddYears(-10);
    // Console.WriteLine(ye);
    Regex regex=new Regex("^[0-9A-Za-z]*$");
    string a =Console.ReadLine();
    bool s=regex.IsMatch(a);
    if(s){
        Console.WriteLine("Valid");
    }
    else{
        Console.WriteLine("Invalid");
    }
    
    }
}