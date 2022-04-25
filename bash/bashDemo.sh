#!/usr/bin/bash

echo Welcome to calculator friend!
echo What is you name?
read name
echo
echo Hello "$name"
echo
read
echo Please choose a function

num1=$1
num2=$2

#functions
Add()
       {
    echo You chose addition
    echo Enter your first number
    read num1
    echo Enter your second number
    read num2
    echo "Press enter for answers"
    read
    echo The sum of $num1 and $num2 is $((num1 + num2))
    echo

      }
Subtract()
            {
    echo You chose substraction
    echo Enter your first number
    read num1
    echo Enter your second number
    read num2
    echo "Press enter for answers"
    read
    echo The difference of $num1 and $num2 is $((num1 - num2))
    echo
            }
Multiply()
        {
    echo You chose to multiply
    echo Pleae enter your first number
    read num1
    echo Pleae enter your second number
    read num2
    echo "Press enter for answers"
    read
    echo The differemce of $num1 and $num2 is $((num1 * num2))
    echo
        }
Divide()
        {
    echo You chose division
    echo Please enter your first number
    read num1
    echo Please enter your second number
    read num2
    echo "Press enter for answers"
    read
    echo The difference of $num1 and $num2 is $((num1 / num2))
    echo
        }
#offer options
if [ $# == 0 ] ; then
while true
do

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
    Add 
    echo

#Subtract
 elif [ $option == 2 ] ; then
    Subtract 
    echo

 #multiply
 elif [ $option == 3 ] ; then
    Multiply
    echo
 
 #divide
 elif [ $option == 4 ] ; then
    Divide 
    echo
 #exit   
 elif [ $option == 5 ] ; then
    exit
 else
    echo 
    echo Invalid option.. Please try again
    echo

    fi
done 
fi

