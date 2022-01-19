amenu="1: Dean Winchester"
bmenu="2: Sam Winchester"
cmenu="3: Castiel"
dmenu="4: Bobby Singer"
emenu="5: Not Listed"
result="true"
retest="true"

deanNum=0
samNum=0
castielNum=0
bobbyNum=0
unlistedNum=0

#testing Number for nested if statement
#test=5

echo "Please select your favorite Supernatural character:"
echo ""
echo "$amenu"
echo "$bmenu"
echo "$cmenu"
echo "$dmenu"
echo "$emenu"
echo ""
read ans
echo ""

while [ "$result" == "true" ]
do
    if [ "$ans" == "1" ]
        then
        deanNum=$(($deanNum+1))
        echo "$deanNum people have picked Dean Winchester"
        echo "Would someone else like to vote?"
        echo "Yes or No"
        echo ""
        read response
        echo ""
            if [ "$response" == "No" ]
                then
                    result="false"
                    retest="false"
            else
                retest="false"
                echo "Please select your favorite Supernatural character:"
                echo ""
                echo "$amenu"
                echo "$bmenu"
                echo "$cmenu"
                echo "$dmenu"
                echo "$emenu"
                echo ""
                read ans
                echo ""
            fi

    elif [ "$ans" == "2" ]
        then
            samNum=$(($samNum+1))
            echo "$samNum people have picked Sam Winchester"
            echo "Would someone else like to vote?"
            echo "Yes or No"
            echo ""
            read response
            echo ""
            while [ "$retest" == "true" ]
            do
                if [ "$response" == "No" ]
                    then
                        result="false"
                        retest="false"
                elif [ "$response" == "Yes" ]
                    then
                        retest="false"
                        echo "Please select your favorite Supernatural character:"
                        echo ""
                        echo "$amenu"
                        echo "$bmenu"
                        echo "$cmenu"
                        echo "$dmenu"
                        echo "$emenu"
                        echo ""
                        read ans
                        echo ""
                else
                echo "I didn't understand please type: Yes or No"
                read response
                wait
                fi
            done

    elif [ "$ans" == "3" ]
        then
        castielNum=$(($castielNum+1))
        echo "$castielNum people have picked Castiel"
        echo "Would someone else like to vote?"
        echo "Yes or No"
        echo ""
        read response
        echo ""
            if [ "$response" == "No" ]
                then
                    result="false"
                    retest="false"
            else
                retest="false"
                echo "Please select your favorite Supernatural character:"
                echo ""
                echo "$amenu"
                echo "$bmenu"
                echo "$cmenu"
                echo "$dmenu"
                echo "$emenu"
                echo ""
                read ans
                echo ""
            fi

    elif [ "$ans" == "4" ]
        then
        bobbyNum=$(($bobbyNum+1))
        echo "$bobbyNum people have picked Bobby Singer"
        echo "Would someone else like to vote?"
        echo "Yes or No"
        echo ""
        read response
        echo ""
            if [ "$response" == "No" ]
                then
                    result="false"
                    retest="false"
            else
                retest="false"
                echo "Please select your favorite Supernatural character:"
                echo ""
                echo "$amenu"
                echo "$bmenu"
                echo "$cmenu"
                echo "$dmenu"
                echo "$emenu"
                echo ""
                read ans
                echo ""
            fi

    elif [ "$ans" == "5" ]
        then
        unlistedNum=$(($unlistedNum+1))
        echo "$unlistedNum people have picked someone not listed"
        echo "Would someone else like to vote?"
        echo "Yes or No"
        echo ""
        read response
        echo ""
            if [ "$response" == "No" ]
                then
                    result="false"
                    retest="false"
            else
                retest="false"
                echo "Please select your favorite Supernatural character:"
                echo ""
                echo "$amenu"
                echo "$bmenu"
                echo "$cmenu"
                echo "$dmenu"
                echo "$emenu"
                echo ""
                read ans
                echo ""
            fi

    else
        echo "You did not pick a valid option... aborting program"
        result="false"
    fi

done

echo "$deanNum people have picked Dean Winchester"
echo "$samNum people have picked Sam Winchester"
echo "$castielNum people have picked Castiel"
echo "$bobbyNum people have picked Bobby Singer"
echo "$unlistedNum people have picked someone not listed"