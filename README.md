# Character Frequency Analysis

This console application, called "frequencies", performs frequency analysis on a text file and displays the most frequently used characters.

## Getting Started

To use and run the solution, follow the steps below.

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) installed on your machine.

### Installation

1. Clone or download the solution from the repository.
2. Open a terminal or command prompt and navigate to the root directory of the solution.

### Build

To build the solution and generate the executable file, run the following command:

```shell
dotnet build --configuration Release
```
## Usage

To run the application, open a command prompt and navigate to the directory containing the executable file.

Use the following command:

```shell
frequencies.exe <file-path> <case-sensitive-flag>
```
Replace <file-path> with the path to the text file you want to analyze, and <case-sensitive-flag> with "Y" for case-sensitive analysis or any other value for case-insensitive analysis.

For example, to analyze the sample.txt file in case-insensitive mode:
  
```shell
frequencies.exe sample.txt N
```
  
This command assumes that the `frequencies.exe` file is in the current directory. Replace `sample.txt` with the path to the text file you want to analyze. The `N` flag specifies case-insensitive analysis. Use `Y` for case-sensitive analysis.

## Output

The application will display the following information:

- The total number of characters read, excluding whitespace characters.
- The top 10 most frequent characters, along with the number of occurrences of each.
