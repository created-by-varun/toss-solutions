def jSeries(n) : 

    a = n 
      
    print a, 

    while (a != 1) : 
        b = 0
          
        if (a%2 == 0) : 
            b  = (int)(math.floor(math.sqrt(a))) 
   
        else : 
            b = (int) (math.floor(math.sqrt(a)*math.sqrt(a)*
                                         math.sqrt(a))) 
   
        print b, 
        a = b 
  
jSeries(7) 

jSeries(5) 
