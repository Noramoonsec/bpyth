ucgenler=[]
for a in range(1,100):
    for b in range(1,100):
        for c in range(1,100):
            if (a**2)+(b**2)==(c**2):
                ucgenler.append(a)
                ucgenler.append(b)
                ucgenler.append(c)
print(ucgenler)