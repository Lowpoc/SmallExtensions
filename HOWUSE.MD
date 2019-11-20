# SmallExtensions

**Summary**

- [Installation](#Installation)
- [Examples](#Examples)
  - [Strings](#Strings)
    - [Invert](#Invert)
    - [IsNullOrEmpty](#IsNullOrEmpty)
    - [IsNullOrWhiteSpace](#IsNullOrWhiteSpace)
    - [IsAlphaNumeric](#IsAlphaNumeric)
    - [OnlyNumbers](#OnlyNumbers)
    - [OnlyAlphabet](#OnlyAlphabet)
    - [RemoveAllWhiteSpaces](#RemoveAllWhiteSpaces)
    - [Captalize](#Captalize)
    - [In](#In)
    - [IsAlphabet](#IsAlphabet)
    - [ZeroFill](#ZeroFill)
    - [FindWords](#FindWords)
    - [WithoutAccents](#WithoutAccents)
  - [Dates](#Dates)
    - [Yesterday](#Yesterday)
    - [Format](#Format)
    - [LastDayOfTheMonth](#LastDayOfTheMonth)
    - [InTheSameMonthCurrent](#InTheSameMonthCurrent)
    - [AreInTheLastYear](#AreInTheLastYear)
    - [AreInTheLastSemester](#AreInTheLastSemester)
    - [AddWeeks](#AddWeeks)
    - [AddFortnights](#AddFortnights)
    - [AddBimesters](#AddBimesters)
    - [AddQuarters](#AddQuarters)
    - [AddHalfYears](#AddHalfYears)
  - [Decimal](#Decimal)
    - [IsPositive](#IsPositive)
    - [IsNegative](#IsNegative)
    - [Positive](#Positive)
    - [Nevative](#Negative)
    - [RoundTo](#RountTo)
    - [Percent](#Percent)
    - [PercentOf](#PercentOf)

## Installation

Package Manager (Visual Studio):

```
Install-Package SmallExtensions
```

.NET CLI:

```
dotnet add package SmallExtensions
```

## Examples

## Strings

### Invert

This method invert a string.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.Invert(); // 321 dcbsa
```

### IsNullOrEmpty

This method verify if string is null or empty.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.IsNullOrEmpty(); //false
```

### IsNullOrWhiteSpace

This method verify if string is null or whitespace.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.IsNullOrWhiteSpace(); //false
```

### IsAlphaNumeric

This method verify if string is alphanumeric.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.IsAlphaNumeric(); //true
```

### OnlyNumbers

This method remove all caracteres except numbers.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.OnlyNumbers(); //123
```

### OnlyAlphabet

This method remove all caracteres except alphabet.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.OnlyAlphabet(); //asbcd
```

### RemoveAllWhiteSpaces

This method remove all white spaces.

```c#
using SmallExtensions.API.Extensions;

string text = " asbcd 123 ";
text.RemoveAllWhiteSpaces(); //asbcd123
```

### Captalize

This method converts the first character of a string to capital(uppercase) letter. If the string has its first character as capital, then it returns the original string.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.Captalize(); //Asbcd 123
```

### In

Searches the string for a specified value.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.In(caseSensitive: false, "As"); //true
text.In(caseSensitive: true, "As"); //false
```

### IsAlphabet

This method verify if string is only alphabet.

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd 123";
text.IsAlphabet(); //false
text.OnlyAlphabet().IsAlphabet(); //true
```

### ZeroFill

The method adds zeros (0) at the beginning of the string, until it reaches the specified length

```c#
using SmallExtensions.API.Extensions;

string text = "asbcd";
text.ZeroFill(6); // "0asbcd"
text.ZeroFill(5); // "asbcd"
```

### FindWords

The method returns a collection of words found in the text.

```c#
using SmallExtensions.API.Extensions;

var words = "Marcus Vinicius Santana Silva".FindWords(caseSensitive: false, "us"); // List<Words>

class Word {
    string value;
    ICollection<Location> Locations;
    int Ocorrences;
}
```

### WithoutAccents

Remove all accents.

```c#
using SmallExtensions.API.Extensions;

var text = "áõôí";
text.WithoutAccents(); // aooi
```

## Dates

### Yesterday

The method return a (datetime - 1 day).

```c#
using SmallExtensions.API.Extensions;

var date = new DateTime(2018,11,14);
date.Yesterday(); // new DateTime(2018,11,13)
```

### Format

Method to format dates in different formats. The following table describes various date time formats and their results. Here we see all the patterns of the DateTime Class.

Formats: "MM/dd/yyyy" (default), "dddd, dd MMMM yyyy", "dddd, dd MMMM yyyy HH:mm:ss".

Link for see others formats: https://docs.microsoft.com/pt-br/dotnet/api/system.datetime.tostring?view=netframework-4.8

```c#
using SmallExtensions.API.Extensions;

var date = new DateTime(2018,11,14);
date.format(); //14/11/2018
```

### LastDayOfTheMonth

This method return the last day of month.

```c#
using SmallExtensions.API.Extensions;

var date = new DateTime(2018,11,14);
date.LastDayOfTheMonth(); // new DateTime(2018,11,30)
```

### InTheSameMonthCurrent

This method check if a date belongs in the month current.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2019,11,14);
var date = new DateTime(2018,11,14);

date.InTheSameMonthCurrent(); // true;
```

### AreInTheLastYear

This method check if a date belongs the last year.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2019,11,14);
var date = new DateTime(2018,11,14);

date.AreInTheLastYear(); // false;
```

### AreInTheLastSemester

This method check if a date belongs the last semester.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2018,7,14);
var date = new DateTime(2018,11,14);

date.AreInTheLastSemester(); // true;
```

### AddWeeks

The method add Weeks.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2019,11,20);

today.AddWeeks(1); // new Datetime(2019,11,27);
```

### AddFortnights

The method add Fortnights.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2019,11,5);

today.AddFortnights(1); // new Datetime(2019,11,20);
```

### AddBimesters

The method add Bimesters.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2019,11,5);

today.AddBimesters(1); // new Datetime(2020,1,5);
```

### AddQuarters

The method add Quarters.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2019,11,5);

today.AddQuarters(1); // new Datetime(2020,2,5);
```

### AddHalfYears

The method add HalfYears.

```c#
using SmallExtensions.API.Extensions;

var today = new Datetime(2019,6,5);

today.AddHalfYears(1); // new Datetime(2020,11,5);
```

## Decimal

### IsPositive

The method verify if the value is positive (>= 0).

```C#
decimal amount = 10M;
amount.IsPositive(); // true;

decimal amountNegative = -10M;
amount.IsPositive(); // false;
```

### IsNegative

The method verify if the value is negative (< 0).

```C#
decimal amount = 10M;
amount.IsNegative(); // false;

decimal amountNegative = -10M;
amount.IsNegative(); // true;
```

### Positive

Convert value negative for positive.

```C#
decimal amount = -10M;
amount.Positive(); // 10M;
```

### Negative

Convert value positive for negative.

```C#
decimal amount = 10M;
amount.Negative(); // -10M;
```

### RountTo

Rounds a decimal value to the specified number of fractional digits and uses the specified rounding convention for the midpoint values.

```C#
decimal amount = 10.2599M;
amount.RoundTo(2); // 10.26M;
```

### Percent

The method returns what is the value of a given percentage.

```C#
decimal amount = 10M;
amount.Percent(50); // 5M;
```

### PercentOf

The method returns which is the percentage of a value with the total value.

```C#
decimal amount = 10M;
decimal total = 100M;
amount.PercentOf(total); // 10;
```