# iKariera Coding Challenge

This repo contains code challenges for the iKariéra Jobfair hosted at Czech Technical University in Prague between *09.04.2019 - 10.04.02019* at *09:00-16:00*.

## Resolving challenges

You probably already know the prize at stake from our colleagues at the booth - a chance to engage with Microsoft employees during a barbeque on the terrace :fork_and_knife: for the first 20 people to resolve as many challenges as possible.

Please take note that you **must** be a student at Czech Technical University in Prague in order to be eligible for the prize at stake. If selected for the barbeque on the terrace :fork_and_knife:, you will have to present your valid student ID issued by the university. The challenges are free to be resolved by anyone.

The hard deadline for this challenge is **21.04.2019 23:55 CET**.

We will announce the winners by **28.04.2019 23:55 CET** via email.

After you finish the challenges, please make sure to email us at [joinprg@microsoft.com](mailto:joinprg@microsoft.com) with details on how to access your repository (you will add one of the judges as [collaborator](https://help.github.com/en/articles/inviting-collaborators-to-a-personal-repository)). Please include - `[iKariera]` - in the subject line when sending this email :bow:

### Prerequisites

* [.NET Core 2.1+](https://dotnet.microsoft.com/download)
* [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio 2017+](https://visualstudio.microsoft.com/downloads/)
* an appetite for coding

An minimal knowledge of C# is required in order to resolve those challenges. For a complete list of tutorial please refer to the [Microsoft docs](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/). If you wish to resolve those challenges in a different programming language please email [joinprg@microsoft.com](mailto:joinprg@microsoft.com).

### Project structure

The solution contains 3 projects:
* **CodingChallenges** which contains static classes with an entry point
* **CodingChallenges.Tests** which contains test classes with different assertions
* **CodingChallenges.Worker** which is a console application meant to help you in debugging

### How to get started
[Create a new **private** repository](https://help.github.com/en/articles/creating-a-new-repository) and start resolving the challenges. GitHub offers [unlimited private repositories](https://github.com/pricing) for individual accounts. Making your repository private is *critical* if you don't want others getting inspired by your solutions.

After you finish the challenges, please make sure to email us at [joinprg@microsoft.com](mailto:joinprg@microsoft.com) with details on how to access your repository (you will add one of the judges as [collaborator](https://help.github.com/en/articles/inviting-collaborators-to-a-personal-repository)). Please include - `[iKariera]` - in the subject line when sending this email :bow:

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

We do not collect or store any personal data prior to cloning, forking or mirroring this repository. If you do not wish to participate in the contest, delete the fork/clone.

By forking or cloning this repository you hereby agree to delete your fork/repository if you do no want your code to be made public.

We do not collect, store or use your personal email address for any purpose other than updates on this challenge or notifying in the case of winning.

After the challenge is over, any judge added as a collaborator will self remove from your repository, if you gave them access.

## Feedback
* File a bug in [GitHub Issues](https://github.com/MicrosoftPrague/iKariera-coding-challenge/issues) if you found something wrong with a test or with a challenge.

## License
Licensed under the [MIT License](LICENSE).
