print("========Calculator of average grade========")

List_grades=int(input ("Enter number of grades: "))

avarage = 0

for i in range(List_grades):
   grade = float(input(f"enter your grade {i+1}: "))
   avarage=avarage + grade

end_avarage= avarage/List_grades

if end_avarage>=3.0:
    print(f"Congratulation you passed the class, your avaragie is {end_avarage}")
else :
    print(f"unfortunetly you failed the class, your avarage is {end_avarage}")
