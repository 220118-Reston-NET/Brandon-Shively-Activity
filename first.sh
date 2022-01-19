# add info if needed
# this wont be processed as code
# type whatever you want
msg="Hello World"
echo $msg
#Use $ to call a variable while the = is used to assign a variable

#Control Flow
# They are a way for us to tell the program what line of code we want to run
# or how many times we want to run a piece of code

# IF statements
# It will only run the line of code if a condition is true

ten=10
five=5
thirteen=13

# 10 > 5 then run these lines of code
echo "===First If==="
if [ "$ten" -ge "$five" ]
then
echo "greater!"
echo "$ten > $five"
fi

echo "===Second If==="
if [ "$ten" -le "$thirteen" ]
then
echo "less!"
echo "$ten < $thirteen"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
echo "$five > $ten"
elif [ "$ten" -le "$five" ]
then
echo "greater!"
echo "$ten > $five"
else
echo "Nothing Works"
fi

#Loop Statements
# It will run that line of code multiple times as long as the condition is true

# For Loop
# Useful if you know how many times you want to run a line of code
# Will run code x amount of times (you set this)
echo "===For Loop==="
for num in 1 2 3 4 5
do
echo "Repeating $num!"
done

echo "===For Loop 2==="
for num in {1..10}
do
echo $num
done

#While Loops
# will repeat the code as long as the condition is true
# useful if you don't know how many times a block of code needs to run

echo "===While Loop==="
while [ "$five" -lt "$ten" ]
do
echo "greater!"
echo "$five"
five=$(($five+1))
done

# Input and Output
# We can ask the input for user that is currently using the shell script
# We can output a response

#echo "What is your name?"
#read name
#echo "Hello $name, welcome to programming!"

# we will combine everything to create a menu-like interface of our terminal that
# will ask the use information and process that information base don whatever 
# they want

clear

repeat="true"

while [ "$repeat" == "true" ]
do
echo "Welcome to shell script!"
echo "What do you want to do today"
echo "Enter 1 if you want to add two numbers"
echo "Enter 2 if you want to exit out of the program"
read ans

if [ "$ans" == "1" ]
then
echo "Give me two numbers"
read num1
read num2
echo "This is your numer $(($num1+$num2))"
else if [ "$ans" == "2" ]
then
echo "Goodbye"
repeat="false"
else
echo "Command not found"
fi

done
clear
