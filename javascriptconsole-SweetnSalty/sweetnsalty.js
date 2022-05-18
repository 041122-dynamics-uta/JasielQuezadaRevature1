
let sw = 0; 
let st = 0;
let swst = 0;
let check = 0; //keep count of how many of each there is
let line = '';
for ( var s = 1; s <= 1000; s++)// Print the numbers 1 to 1000 to the console. 
{
    console.log(s);
    if (s % 20 == 0)//seperate by 20 
    {
        console.log(line)
        line = '';
    }  
    if (s % 3 == 0 && s % 5 == 0)//divisible by 3 & 5
    {
        console.log("Sweet'nSalty ");
        swst++;
    }
    else if ( s % 3 == 0) //divisible by 3
    {
        console.log("Sweet");
        sw++;
    }
    else if (s % 5 == 0)//divisble by 5
    {
        console.log("Salty");
        st++;
    }            
    else
    {
        console.log(s);//just print number
    }
    check++;                
}

        console.log();
        console.log(`The Number of Sweet is: ${sw}`);
        console.log(`The Number of Sweet is: ${st}`);
        console.log(`The Number of Sweet is: ${swst}`);
        console.log();

// Print the numbers in groups of 20 per line with one space separating each number.  
// HINT: Use string concatenation to print the 20-number strings to the console at a time.  
// When the number is a multiple of three, print “Sweet” instead of the number on the console. 
// If the number is a multiple of five, print “Salty” (instead of the number) to the console.    
// For numbers which are multiples of three and five, print “Sweet’nSalty” to the console (instead of the number).    
// After the numbers have all been printed, print out: 
// How many "Sweet”,  
// how many "Salty”, and  
// how many "Sweet’nSalty".  
//Sweet, Salty, and Sweet’nSalty are three separate groups,
// so Sweet’nSalty does not increment Sweet or Salty (and vice versa).   