# Sum and Count of Even and Odd Numbers in a Range

## Instructions for Running the Program

1. Open **Visual Studio** or any C# IDE of your choice.
2. Copy and paste the code from the provided source file into the IDE.
3. Compile and run the program.
4. Follow the on-screen instructions to input the range and view the results.

## Tasks Performed by the Program

- The program calculates the sum of even and odd numbers within a specified range.
- It validates the user inputs to ensure proper range values are provided.
- It handles invalid inputs and impossible ranges gracefully.

## Description of the Program

This program prompts the user to input a start and end value, defines a range, and computes the sum of even and odd numbers within that range. The program includes input validation and error handling for invalid or reversed ranges.

### Key Aspects:

- **Input validation**: Ensures valid integers are provided as start and end values.
- **Range validation**: Checks that the end value is greater than or equal to the start value.
- **Summation logic**: Separates and sums even and odd numbers in the specified range.

## Features of the Program

### Step-by-Step Explanation:

1. The user is prompted to input the start value of the range.
   - If the input is invalid, an error message is displayed, and the program terminates.
2. The user is prompted to input the end value of the range.
   - Similarly, invalid input or an end value less than the start value results in an error message and termination.
3. If the inputs are valid:
   - The program iterates through the range from the start to the end value.
   - It checks each number for parity:
     - Adds even numbers to the even sum.
     - Adds odd numbers to the odd sum.
4. After completing the iteration, the program outputs:
   - The sum of even numbers in the range.
   - The sum of odd numbers in the range.

### Program Structure:

- **Input Handling**:
  - Reads the start and end values using `Console.ReadLine()`.
  - Validates the inputs with `int.TryParse`.
  - Verifies that the range is valid (end value >= start value).

- **Summation Logic**:
  - Uses a `while` loop to traverse the range.
  - Determines if each number is even or odd using the modulus operator (`%`).

- **Output Messages**:
  - Displays the sums of even and odd numbers in the range.
  - Provides clear error messages for invalid input or impossible ranges.

## Program Logic Summary

This program combines input validation, range checking, and summation to compute the sums of even and odd numbers in a user-defined range. Its design ensures robustness by handling various edge cases, such as invalid inputs or reversed ranges. The program is well-suited for educational use or as an example of fundamental C# programming concepts.
