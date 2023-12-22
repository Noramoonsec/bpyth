fib=[]
fib.append(1)
fib.append(1)
for i in range(2,5000000):
    fib.append(fib[i-2]+fib[i-1])
    if sum(fib)>500:
        break
print(fib)
print(sum(fib))

