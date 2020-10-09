
# Blazor Workshop
Welcome to the Blazor Workshop. In this README you will find all the necessary information to get started.

## Setup
What do we need?

 - A working notebook or PC
 - .NET Core 3.1 from [here](https://dotnet.microsoft.com/download/dotnet-core/3.1)
	 - After installation open a command line and type in the following:
	 - > dotnet --list-runtimes
	 - > dotnet --list-sdks
	 - It should print out information about the installed SDK's and its versions
	 - The important runtimes are: Microsoft.NETCore.App 3.1.8 and Microsoft.AspNetCore.App 3.1.8

 - On the same site you will find the Installer for ASP.NET Core 3.1.
 - Make sure you have the latest version of Visual Studio 2019 running (16.7.5 or higher)
 - You need a `git` client. Please install the latest if you haven't from the [official site](https://git-scm.com/downloads) for your OS

## Let the fun begin
Clone this repository and open the LinkDotNet.BlazorWorkshop.sln
To clone this repo use the following command:
`git clone https://github.com/linkdotnet/BlazorWorkshop.git`

## Debugging
This project is setup so you can attach the debugger or directly start with the debugger (aka Server Side Blazor).
You can reuse the code for client side blazor (it is totally the same) but client side blazor lacks some of the debugging-capability.

## Tasks
This workshop has various tasks which are split up to different branches.
Use your IDE or the git's switch command to switch between branches.
There is also a Tests project which should get green if the component is correctly implemented.
Just run `dotnet test` or use your IDE to run the Unit test and see if you could do the task.

### Task 1
Switch to the following branch: `task/1-add-numbers`.
For example via git:
> `git switch task/1-add-numbers`

Or if you use git older than version 2.23 (which you shouldn't :smirk:)
> `git checkout task/1-add-numbers`

The task will be to add two numbers (prodvided in a text box) and display the result

### Task 2
Switch to the following branch `task/2-input-parameter`
> `git switch task/1-add-numbers`

This time you have to extend the given Counter example with a state.

### Task 3
Switch to the following branch `task/3-ref-parameter`
> `git switch task/3-ref-parameter`

How do we control Components from the outside world?