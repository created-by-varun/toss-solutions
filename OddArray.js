function findOdd(numbers) {
    let count = 0;
    for(let i = 0; i<numbers.length; i++){
      for(let j = 0; j<numbers.length; j++){
        if(numbers[i] == numbers[j]){
          count++;
        }
      }
      if(count % 2 != 0 ){
        return numbers[i];
      }
    }
  };
  
  console.log(findOdd([1,1,1,1,2,2,3,3,4,4,5,4,5])); //4
