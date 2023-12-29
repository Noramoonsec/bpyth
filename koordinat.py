x1 = int(input("x1 i giriniz: "))
x2 = int(input("x2 i giriniz: "))
y1 = int(input("y1 i giriniz: "))
y2 = int(input("y2 i giriniz: "))
m = ((y1-y2)/(x1-x2))
c =y1-x1
print(f"""
mx={m}x
y={m}x+c
c={c}
y={int(m)}x+{c}""")
