const getSleepHours = day => {
  day = day.toLowerCase();
  switch(day) {
    case 'monday' : return 4;
    break;
    case 'tuesday' : return 5;
    break;
    case 'wednesday' : return 7;
    break;
    case 'thursday' : return 5;
    break;
    case 'friday' : return 4;
    break;
    case 'saturday' : return 6;
    break;
    case 'sunday' : return 8;
  } 
 };
 
 const getActualSleepHours = () =>
   getSleepHours('monday') +
   getSleepHours('tuesday') +
   getSleepHours('wednesday') +
   getSleepHours('thursday') +
   getSleepHours('friday') +
   getSleepHours('saturday') +
   getSleepHours('sunday');

   const getIdealSleepHours = () => {
     const idealHours = 8;
      return idealHours * 7;
   }

const calculateSleepDebt = () => {
  const actualSleepHours = getActualSleepHours();
  const idealSleepHours = getIdealSleepHours();
  if (actualSleepHours === idealSleepHours) {
    return `You are well rested! You got ${actualSleepHours} hours of sleep!`;
  } else if (actualSleepHours > idealSleepHours) {
    return `You slept too long! You slept ${(actualSleepHours - idealSleepHours)} hour(s) too many!`;
  } else {
    return `You should probably get some rest. You got ${(idealSleepHours - actualSleepHours)} hour(s) less sleep than you needed this week.`;
  }
}

console.log(calculateSleepDebt());
