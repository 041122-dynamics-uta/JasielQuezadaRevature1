#!/usr/bin/bash

echo Welcome to calculator friend!
echo Please choose a function

num1=$1
num2=$2

if [[ $# -eq 0 ]] ; then
while true
do
#offer options
    echo 1. Addition
    echo 2. Subtraction
    echo 3. Multiplication
    echo 4. Division
    echo 5. Exit
    echo Enter your option:
    read option

 #get option and solve
 if [[ $option -eq 1 ]] ; then
    echo You chose to add the numbers             
    echo Enter your first number
    read num1
    echo Enter your second number
    read num2
    echo $num1 + $num2  
    echo "Press enter for answers"
    read 
    echo The sum of $num1 and $num2 is $((num1 + num2)) 

 elif [[ $option -eq 2 ]] ; then
    echo You chose to substract the numbers 
    echo Enter your first number
    read num1
    echo Enter your second number
    read num2
    echo "Press enter for answers"
    read 
    echo The difference of $num1 and $num2 is $((num1 - num2)) 

 elif [[ $option -eq 3 ]] ; then
    echo You chose to multiply the numbers 
    echo Pleae enter your first number
    read num1
    echo Pleae enter your second number
    read num2
    echo "Press enter for answers"
    read 
    echo The differemce of $num1 and $num2 is $((num1 * num2))

 elif [[ $option -eq 4 ]] ; then
    echo You chose to divide the numbers
    echo Please enter your first number
    read num1
    echo Please enter your second number
    read num2
    echo "Press enter for answers"
    read 
    echo The differemce of $num1 and $num2 is $((num1 / num2)) 

 elif [[ $option -eq 5 ]] ; then
    exit
 else
    echo 
    echo Invalid option.. Please try again
    echo  
    fi
done
else
    echo Invalid option 
end
fi
    add() 
	    { results=$((num1 + num2))
	    end
	}
	subtract()
		{ results=$((num1 - num2))
	    end
	}
	multiply() 
		{ results=$((num1 * num2))
	    end	
	}		
	divide()
	{
	if [ $num2 == 0 ]
	then
		echo Divide by 0 error ! Press enter to continue
		read
		inputnumbers
		break
	else
		results=$((num1 / num2))
		end

    }
else
    echo Invalid choice    

fi
