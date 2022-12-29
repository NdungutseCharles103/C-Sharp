from module import greeting, person1
import module as md 
import platform

greeting('Charles')
print(person1['name'])
md.greeting('Mount')

x = platform.system()
print(x)
dirx = dir(platform)
# print(dirx)
print(platform.processor())
