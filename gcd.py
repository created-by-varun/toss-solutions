def Gcd(x, y): 
      
    while(y): 
        x, y = y, x % y 
      
    return x 
                  
l = [3,6,9,21,18,99] 
  
a = l[0] 
b = l[1] 
gcd = Gcd(a, b) 
  
for i in range(2, len(l)): 
    gcd = Gcd(gcd, l[i]) 
      
print(gcd) 
