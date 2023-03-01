# Parcel

#### By E. Luckie ☀️

#### This webpage acts as a shipping cost estimator for a faux shipping company.

## Technologies Used

* C#
* Dotnet
* MSTest
* Markdown
* Git

## Description

This webpage acts as a shipping cost calculator for a faux business. From the homepage, users are instructed to fill in the form with their package's length, width, and height in inches and the package's weight in pounds. Once they click calculate, they're displayed their packages dimensions along with the volume and total shipping cost. From there, users are able to click the link at the bottom to calculate another package's shipping cost.

## Setup/Installation Requirements

1. Clone this repo
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called **Parcel**
3. In the command line, run the command ``dotnet watch run`` to compile and execute the console application in your browser in development mode
* This will also automatically run the _restore_ command to retrieve and install the necessary packages for this application
* Optionally, you can run ``dotnet build`` to compile this console app without running it

### To Run Tests
1. Navigate to this project's test directory called **Parcel.Tests**
2. If the project hasn't already been restored, run ``dotnet restore``
3. In the command line, run the command ``dotnet test`` to perform the tests and verify 100% pass-rate

## Known Bugs

* If user does not enter a number, package still submits but calculations are incorrect because they're using a 0.

## License

MIT License

Copyright (c) 2023 Luckie