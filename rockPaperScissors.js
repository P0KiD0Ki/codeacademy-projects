const getUserChoice = userInput => {
userInput = userInput.toLowerCase();
if (userInput === 'rock' || userInput === 'paper' || userInput === 'scissors' || userInput === 'bomb') {
  return userInput
} else {
  return 'Ope! Ya dun goofed, kid.'
}
};

const getComputerChoice = () => {
  let randomNumber = Math.floor(Math.random() * 3);
  if (randomNumber === 0) {
     return 'rock';
  } else if (randomNumber === 1) {
    return 'paper';
  } else {
    return 'scissors';
  };
};

const determineWinner = (userChoice, computerChoice) => {
 if (userChoice === computerChoice) {
   return 'Issa tie, fam!'
 };
 if (userChoice === 'rock') {
   if (computerChoice === 'paper') {
     return 'Welcome your robot overlord bc you lost!'
   } else {
     return 'You won!'
   };
 }
  if (userChoice === 'paper') {
   if (computerChoice === 'scissors') {
     return 'Welcome your robot overlord bc you lost!'
   } else {
     return 'You won!'
   };
 }
  if (userChoice === 'scissors') {
   if (computerChoice === 'rock') {
     return 'Welcome your robot overlord bc you lost!'
   } else {
     return 'You won!'
   };
 }
 if (userChoice === 'bomb') {
   if (computerChoice === 'rock' || computerChoice === 'paper' || computerChoice === 'scissors') {
     return 'You cheeky bastard... You won (duh)!'
   }
 }
 if (userChoice === 'Ope! Ya dun goofed, kid.') {
   return 'Computer wins by default!'
 }
}

const playGame = () => {
  const userChoice = getUserChoice('bewb');
  const computerChoice = getComputerChoice();
  console.log(`You threw: ${userChoice}`);
  console.log(`The computer threw: ${computerChoice}`);
  console.log(determineWinner(userChoice, computerChoice));
};

playGame();
