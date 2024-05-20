# JSON-Based Calculator

## Description

JSON-Based Calculator is a C# application that reads data from a JSON file, performs specified mathematical operations on the input data, and writes the results to an output file in ascending order by value.

## Features

- Reads input data from a JSON file.
- Processes objects containing fields: `operator`, `value1`, `value2`.
- Performs mathematical operations (addition, subtraction, multiplication, division, square root).
- Writes results to an output file in ascending order by value.

## Input Data Format

The JSON file should contain an object where each key is an object name and each value is an object with the following fields:

- `operator` (string) - the mathematical operation (`add`, `sub`, `mul`, `div`, `sqrt`)
- `value1` (number) - the first value (or the only value for `sqrt` operation)
- `value2` (number) - the second value (not required for `sqrt` operation)

### Example

```json
{
  "obj1": {
    "operator": "add",
    "value1": 2,
    "value2": 3
  },
  "obj2": {
    "operator": "sqrt",
    "value1": 16
  },
  "obj3": {
    "operator": "mul",
    "value1": 2,
    "value2": 1.5
  },
  "obj4": {
    "operator": "sqrt",
    "value1": -2
  },
  "obj5": {
    "operator": "div",
    "value1": 2,
    "value2": 2
  },
  "obj6": {
    "operator": "sub",
    "value1": 2,
    "value2": 1
  },
  "obj7": {
    "operator": "add",
    "value1": 0.5,
    "value2": 0.5
  }
}

 Installation
1. Clone the repository:
git clone https://github.com/your-repo/json-based-calculator.git

2. Navigate to the project directory:
cd json-based-calculator

3. Open the project in Visual Studio or another C#-compatible IDE.

## Usage
1. Place the input JSON file in the project directory.
2. Run the application.
3. The application will perform the calculations and save the results in an output file in the project directory.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

 ## Author
Author: Patryk Pañczuk