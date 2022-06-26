import 'dart:io';

class Student {
  late String name;
  late String gpa;

  Student(String aName, String aGpa){
    this.name = aName;
    this.gpa = aGpa;
  }
}

 void main() {
  
  Student jim = Student("aName", "30");

  print(jim.name + jim.gpa);
}