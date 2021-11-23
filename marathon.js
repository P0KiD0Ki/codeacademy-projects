//race numbers should be randomly assigned
let raceNumber = Math.floor(Math.random() * 1000);

//is this user an early registrant?
let earlyRegistrant = true;

//how old is this runner?
let runnerAge = 18;

if (runnerAge > 18 && earlyRegistrant) {
  raceNumber += 1000;
}

if (runnerAge > 18 && earlyRegistrant) {
  console.log(`Runner ${raceNumber}: your race is at 9:30 am.`)
} else if (runnerAge > 18 && !earlyRegistrant) {
  console.log(`Runner ${raceNumber}: your race is at 11:00 am.`)
} else if (runnerAge < 18) {
  console.log(`Runner ${raceNumber}: your race is at 12:30.`)
} else {
  console.log('Please check in at the registration desk')
};