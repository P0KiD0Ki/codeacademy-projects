let humanScore = 0;
let computerScore = 0;
let currentRoundNumber = 1;

// Write your code below:
const generateTarget = () => {
  //a random number variable
  return Math.floor(Math.random() * 9);
}

const compareGuesses = (user, computer, secretNumber) => {
  if (user === computer) {
    return 'You win!';
  } else if (user <= secretNumber) {
    return 'You win';
  } else if (computer <= secretNumber) {
    return 'The computer wins!';
  }
}

const updateScore = (winner) => {
  switch (winner) {
    case 'human' : humanScore = humanScore += 1;
    break;
    case 'computer' : computerScore = computerScore += 1;
    break;
  }
};

const advanceRound = () => {
currentRoundNumber += 1;
}