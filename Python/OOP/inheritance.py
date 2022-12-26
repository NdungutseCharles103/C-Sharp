
class Person:
    def __init__(self, names, age):
        self.names = names
        self.age = age
        
    def walk():
        print('I can walk as a human')
    def introduce(self):
       print('My name is '+ self.names + ' and my age is ' +str(self.age))
    

# print("p1.age", "p1.names", "hello", 43, 54, 56, 65)

class Student(Person):
    courses = ['JAVA', 'DSA', 'Physics']
    def __init__(self, names, age, acadYear):
        super().__init__(names, age)
        self.acadYear = acadYear

    def study(self):
        print('I\'m going to study the following courses: ')
        for i in self.courses:
            print(i)

st1 = Student("Charles", 17, 2022)
st1.introduce()
st1.study()

class AdvancedStudent(Student):
    def __init__(self, names, age, acadYear):
        super().__init__(names, age, acadYear)



