def fizz_buzz():
    for i in range(1,101):
        if i % 5 == 0 and i % 3 == 0:
            print(i, "Fizz Buzz!")
        elif i % 3 == 0:
            print(i, "Fizz!")
        elif i % 5 == 0:
            print(i,"Buzz!")