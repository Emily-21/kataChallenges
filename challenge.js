
const equalSlices = (total, recipients, slices) => {
    if (recipients * slices > total){
        console.log(false);
        return false;
    } 
    else  { 
       console.log(true);
        return true;
    };
}

 equalSlices(15, 5, 3); //true
 equalSlices(8, 3, 2); //expect true
 equalSlices(24, 12, 2); //expect true
 equalSlices(8, 3, 3); //expect false
 equalSlices(8, 0, 0); //expect true
 equalSlices(3, 5, 5); //expect false


