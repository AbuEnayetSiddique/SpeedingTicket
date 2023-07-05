// Program name: SpeedingTicket
// Program purpose: To calculate a speeding ticket based on ticketed speed and student classification
// Author: Abu Enayet Siddique
// Date created: 2022-07-15  02438

Welcome note to the Application
creating a class for the ticket

variable declaration 

Input: Getting Input form the user. 
    Here will get student number, speed limit, reported speed and the classification of the person.
        menu to enter the classification
        if Freshman enter 1
        if Shophomore enter 2
        if Junior enter 3
        or if Senior enter 4.
        if entered other than 1-4 it will display the menu again to put the appropriate value.

Processing: processing the speed limit, reported speed and the classification data.
    get the speed data by substracting speed limit form the reported speed.
    this speed number will devided by 5 to calculate for each 5 kpm fine.
    then multiply by $87.5 to each 5 kmp and get the total for the overspeed fine.
    after that adding the base fine $75.00.
    for calculating the classified person used if statement. 

Output: output will be student number, classification of the person, speed limit,
    reported speed and the total fine.

Deskcheck:
    if a Junior drive at 45kmp.
    the speed limit is 35. so, he is driving 10 kmp overspeed
    which will devide by 5 and multiplyed by $87.5
    10/5 =2*87.5 = $175.00 + $75.00 = $250 fine.