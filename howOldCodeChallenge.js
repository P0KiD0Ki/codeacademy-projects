// Write your function here:
  //date variables
  const currentDate = new Date();
  const currentYear = currentDate.getFullYear();

const howOld = (age, year) => {
  
  //age variables
  const yearOfBirth = currentYear - age;
  const futureAge = year - yearOfBirth;
  const yearBeforeBirth = yearOfBirth - year;
  const pastAge = year - yearOfBirth;

  //case handling
  if (year > currentYear) {
    return `You will be ${futureAge} in the year ${year}`;
  } else if (year < yearOfBirth) {
    return `The year ${year} was ${yearBeforeBirth} years before you were born`;
  } else if (year < currentYear && year >= yearOfBirth ) {
    return `You were ${pastAge} in the year ${year}`;
  }
}

// Once your function is written, write function calls to test your code!
console.log(howOld(29, 2038));
console.log(howOld(29, 1880));
console.log(howOld(29, 2000));
