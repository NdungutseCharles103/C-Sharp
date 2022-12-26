
class Person:
    def __init__(self, names, age):
        self.names = names
        self.age = age
        
    def walk():
        print('I can walk as a human')
    def introduce(self):
        print('My name is '+ self.names + ' and my age is ' +str(self.age))
    
p1 = Person('Charles', 17)
p1.introduce()


