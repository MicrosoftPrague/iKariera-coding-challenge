# iKariera Coding Challenge

This repo contains code challenges for the iKariéra Jobfair hosted at Czech technical university in Prague between *09.04.2019 - 10.04.02019* at *09:00-16:00*

## Resolving challenges

You probably already know the prize at stake from our colleagues at the booth - a chance to engage with Microsoft employees during a barbeque on the terrace :fork_and_knife: for the first 20 people to resolve as many challenges as possible.

### Prerequisites

* [Visual Studio 2017+](https://visualstudio.microsoft.com/downloads/)
* [.NET Core 2.1+](https://dotnet.microsoft.com/download)
* an appetite for coding

An minimal knowledge of C# is required in order to resolve those challenges. For a complete list of tutorial please refer to the [Microsoft docc](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/). If you wish to resolve those challenges in a different language please email [laurentiu.stamate@microsoft.com](laurentiu.stamate@microsoft.com).

### Project structure

The solution contains 3 projects:
* **CodingChallenges** which contains static classes with an entry point
* **CodingChallenges.Tests** which contains a test class with different assertions
* **CodingChallenges.Worker** which is a console application meant to help you in debugging

### How to get started
[Fork this repo](https://help.github.com/en/articles/fork-a-repo) and start resolving the challenges.

### Challenge example
```csharp
/****
**  Write a short program that prints each number from 1 to 100 on a new line.
**  For each multiple of 3, print "Fizz" instead of the number.
**  For each multiple of 5, print "Buzz" instead of the number.
**  For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
****/

namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;

    public static class FizzBuzz
    {
        public static void PrintNumbers()
        {
            // TODO Add implementation
        }
    }
}
```

## Privacy
Your privacy is important to us. This repository has adopted the [Microsoft Privacy Statement](https://privacy.microsoft.com/en-us/privacystatement). 

We do not collect or store any personal data prior to forking this repository. If you do not wish to participate in the contest, delete the fork.

During the contest, this repository will remain private. After the contest is finished this repository will be made public, action which will result in your fork to become public aswell. By forking this repo you hereby agree to delete your fork if you do no want your code to be made public. The deadline to do so is **31.04.2019**

## Feedback
* File a bug in [GitHub Issues](https://github.com/oop-pub/laboratoare/issues) if you found something wrong with a test.

## License
Licensed under the [MIT License](LICENSE).