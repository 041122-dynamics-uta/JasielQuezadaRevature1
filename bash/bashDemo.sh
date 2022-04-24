#!/usr/bin/bash

echo Welcome to calculator friend!
echo Please choose a function

num1=$1
num2=$2

if [ $# == 0 ] ; then
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
 #ADD
 if [ $option == 1 ] ; then
    echo You chose addition             
    echo Enter your first number
    read num1
    echo Enter your second number
    read num2  
    echo "Press enter for answers"
    read 
    echo The sum of $num1 and $num2 is $((num1 + num2)) 
    echo

#Subtract
 elif [ $option == 2 ] ; then
    echo You chose substraction 
    echo Enter your first number
    read num1
    echo Enter your second number
    read num2
    echo "Press enter for answers"
    read 
    echo The difference of $num1 and $num2 is $((num1 - num2)) 
    echo

 #multiply
 elif [ $option == 3 ] ; then
    echo You chose to multiply 
    echo Pleae enter your first number
    read num1
    echo Pleae enter your second number
    read num2
    echo "Press enter for answers"
    read 
    echo The differemce of $num1 and $num2 is $((num1 * num2))
    echo
 
 #divide
 elif [ $option == 4 ] ; then
    echo You chose division
    echo Please enter your first number
    read num1
    echo Please enter your second number
    read num2
    echo "Press enter for answers"
    read 
    echo The difference of $num1 and $num2 is $((num1 / num2)) 
    echo
 #exit   
 elif [ $option == 5 ] ; then
    exit
 else
    echo 
    echo Invalid option.. Please try again
    echo
end
    fi
done 
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
	        { results=$((num1 / num2))
		end

        }
else
    echo Invalid choice    

fi
