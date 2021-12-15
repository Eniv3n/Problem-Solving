# DND calculator
import random

standardStatSet = [15, 14, 13, 12, 10, 8]
abilities = ['Str', 'Dex', 'Con', 'Int', 'Wis', 'Cha']
sets = 100


# returns the highest number in a list
def hi(stats):
    hi = 0
    for x in stats:
        if x > hi: hi = x
    return(hi)

# returns the lowest number in a list
def lo(stats):
    lo = 19
    for x in stats:
        if x < lo: lo = x
    return(lo)

# returns the total value of number in a list added together
def total(stats):
    total = 0
    for x in stats: total += x
    return(total)

# returns a number from 1 - 6
def rollD6():
    return(random.randint(1,6))

# returns 4 random numbers from 1 - 6 then removes one instance of the lowest number
def roll4keep3():
    dice1 = rollD6()
    dice2 = rollD6()
    dice3 = rollD6()
    dice4 = rollD6()
    rolls = [dice1, dice2, dice3, dice4]
    rolls.remove(lo(rolls))
    rolls = total(rolls)
    return(rolls)


# Rolls a set of 6 randomly determined stats
def rollStats(stats):
    numStats = []
    for i in stats:
        value = roll4keep3()
        numStats.append(value)
    return(numStats)

# Rolls X sets of 6 randomly determined stats
def rollXstats(stats,X):
    global sets

    counter16 = 0
    newCounter = 0
    counter = 0
    better = 0
    worse = 0
    equal = 0
    sixteenPlus = [16,17,18]
    diceRolled = (int(X)*6)
    while counter < X:
        rolled = rollStats(stats)
        if total(rolled) > total(standardStatSet): better += 1
        elif total(rolled) < total(standardStatSet): worse += 1
        elif total(rolled) == total(standardStatSet): equal += 1

        # uncomment this print command if you want to see every set of stats rolled
        print(rolled)

        # percentage maths
        anotherCounter = 0
        notSixteen = False

        # For each value in a set of 6
        for i in rolled:
            # If the number is 16 or higher, turn notSixteen True
            if i >= 16:
                notSixteen = True
            else: continue

        # So long as notSixteen is false, add 1 to newCounter
        if notSixteen == False:
            newCounter += 1


        counter += 1

    # Number of times a set included at least 1 instance of 16+
    includes16 = sets - newCounter

    #percentageNot16 = ((newCounter/diceRolled)*100)
    #percentage16 = ((counter16/diceRolled)*100)
    #print(str(round(percentage16,2))+"%")
    #print(str(round(percentageNot16, 2)) + "%")

    # Prints percentage of sets created without an instance of 16+
    print("\nnot a single 16:      "+str(round(float(newCounter/sets)*100,2))+"%")

    # Prints percentage of sets created including at least one instance of 16+
    print("\nat least a single 16: "+str(round(float(includes16/sets)*100,2))+"%")


    print("\nBetter: "+ str(better)+"\nWorse: "+str(worse)+"\nEqual: "+str(equal))



# Uncomment the function below to create a set of 6 randomly generated stats
#rollStats(abilities)

# Uncomment the function below and enter the amount of sets at the top of the script, to generate that many sets of 6 randomly generated stats, and print
# whether the total of the numbers in the set is higher than, lower than or equal to the total value of the basic set of stats
rollXstats(abilities,sets)


