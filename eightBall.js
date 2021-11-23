//a variable for the 8 ball user
let userName = "Perla";

//ternary function for greeting the user
userName ? console.log(`Hello, ${userName}!`) : console.log("Hello!");

//question from the user
let userQuestion = "Is learning this worth it?";

//answer to user's first question
console.log(`The user asked: ${userQuestion}`);

//a random number variable
const randomNumber = Math.floor(Math.random() * 8);

//variable for the 8ball
let eightBall = "";

//switch statement to run through the possibilities
switch (randomNumber) {
  case 0:
    eightBall = "It is certain";
    break;
  case 1:
    eightBall = "It is decidedly so";
    break;
  case 2:
    eightBall = "Reply hazy try again";
    break;
  case 3:
    eightBall = "Cannot predict now";
    break;
  case 4:
    eightBall = "Do not count on it";
  case 5:
    eightBall = "My sources say no";
  case 6:
    eightBall = "Outlook not so good";
  case 7:
    eightBall = "Signs point to yes";
    break;
}

//magic 8 ball's response to a question:
console.log(`The 8 Ball answered: ${eightBall}`);
