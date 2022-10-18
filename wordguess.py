#Initial Variables:
correct = False
guesscount = 0
secretword = ("guatemala")
#print("INFO: Word: {}".format(secretword))

hint1 = ""
while len(hint1) < len(secretword):
    hint1 = "{}_ ".format(hint1 * 2)
print("Your initial hint is {}!".format(hint1))

while correct == False:
    guesscount += 1

    guess = input("Your Guess: ").lower()
    correctlength = False
    while correctlength == False:
        if len(guess) != len(secretword):
            print("You used the wrong number of letters, try again.")
            guess = input("Your guess: ").lower()
            guesscount += 1
        else:
            correctlength = True

    #Exit if correct
    if guess == secretword:
        print("Congratulations, you guessed correctly!\nThe word was {}!".format(secretword))
        print("It took you {} attempt(s)!".format(guesscount))
        break
   
    # First Mark all the letters that are guessed correctly
    hint2 = list(guess)
    index = 0
    for guessletter in hint2:
        if guessletter in secretword:
            pass
        else:
            hint2[index] = "_"
            index += 1

    # Capitalize letter if in right position
    index = 0
    while index < len(secretword):
        if hint2[index] == secretword[index]:
            hint2[index] = hint2[index].upper()
        else:
            pass
        index +=1
    
    hint1 = " ".join(hint2)
    print("Your hint is {}".format(hint1))
