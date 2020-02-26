# How to contribute
One of the easiest ways to contribute is to participate in discussions on our Gitter channel https://gitter.im/Nethereum/Nethereum.  We do encourage and accept PR's providing the guidance below is followed.

Much of our guidelines are the same as for .Net Core https://github.com/dotnet/aspnetcore/blob/master/CONTRIBUTING.md.

## General feedback and discussions?
Please use our Gitter channel https://gitter.im/Nethereum/Nethereum.

## Bugs and feature requests?
Before raising an issue on GitHub for a question or feature request or bug, please try Gitter first.  It is important that bugs and feature requests are verified on Gitter before a GitHub issue is raised.  Please don't raise questions as GitHub issues, use Gitter instead.

Ask A Question:
https://gitter.im/Nethereum/Nethereum

Log An Issue (please check Gitter first):
https://github.com/Nethereum/Nethereum/issues

## PR's
We welcome pull requests with code changes that follow our guidelines.  It is strongly recommended that any PR's reference a GitHub issue on our repo. Before committing to work on a PR please contact us via Gitter to verify that the PR is worthwhile and consistent with our roadmap.

## Contributing code and content

We accept fixes and features.  These resources will help you contribute.

* ["Help wanted" issues](https://github.com/Nethereum/Nethereum/labels/help%20wanted) - these issues are up for grabs. Comment on an issue if you want to create a fix.
* If there are no "Help Wanted" issues by all means see what's there and get in touch if you'd like to help.

### Identifying the scale
(As per .Net Core contribution guidelines)

Please read this excerpt from Manuel Icaza's blog:

>Open Source Contribution Etiquette
>by Miguel de Icaza
>
>Some developers, when faced with fixing, or adding a feature to an open source project are under the mistaken impression that the first step before any fixing takes place, or before adding a new feature takes place is to make the code "easier for them" to work on.
>
>"Easier for them" usually is a combination of renaming methods, fields, properties, locals; Refactoring of methods, classes; Gratuitous split of code in different files, or merging of code into a single file; Reorganization by alphabetical order, or functional order, or grouping functions closer to each other, or having helper methods first, or helper methods last. Changing indentation, aligning variables, or parameters or dozen other smaller changes.
>
>This is not how you contribute to an open source project.
>
>When you contribute fixes or new features to an open source project you should use the existing coding style, the existing coding patterns and stick by the active maintainer's choice for his code organization.
>
>The maintainer is in for the long-haul, and has been working on this code for longer than you have. Chances are, he will keep doing this even after you have long moved into your next project.
>
>Sending a maintainer a patch, or a pull request that consists of your "fix" mixed with a dozen renames, refactoring changes, variable renames, method renames, file splitting, layout changing code is not really a contribution, it is home work.
>
>The maintainer now has to look at your mess of a patch and extract the actual improvement, wasting precious time that could have gone to something else. This sometimes negates the effort of your "contribution".
>
>If you really have an urge to refactor the code, first of all, discuss the changes with the maintainer with the rationale for the changes. If the maintainer agrees with the changes, make sure that you keep your refactoring and changes independent from code fixes, it makes reviewing the code a lot simpler.
>
>The alternative, to keep your fork, is usually a guarantee that your effort will be wasted, and wont help other users. People have tried to do this. It is attempted every year, by hunders of developers who in tbe back of their minds are thinking "I can do better" and "I wont make the same mistakes". After 18 years doing open source I can probably think of a handful of project forks that have survived and flourished. Out of hundreds of such failures. So the odds are not good.
>
>So respect the original coding style, and if you want to make refactoring changes, discuss this with the maintainer.
>
> If you would like to contribute, first identify the scale of what you would like to contribute.  If you are submitting a feature or substantial code contribution, please discuss it with the team via Gitter and ensure it follows the product roadmap. You might also read these two blogs posts on contributing code: [Open Source Contribution Etiquette](http://tirania.org/blog/archive/2010/Dec-31.html) by Miguel de Icaza and [Don't "Push" Your Pull Requests](https://www.igvita.com/2011/12/19/dont-push-your-pull-requests/) by Ilya Grigorik. All code submissions will be rigorously reviewed and tested by the team, and only those that meet an extremely high bar for both quality and design/roadmap appropriateness will be merged into the source.

### Submitting a pull request
(As per .Net Core contribution guidelines)

> If you don't know what a pull request is read this article: https://help.github.com/articles/using-pull-requests. Make sure the repository can build and all tests pass. Familiarize yourself with the project workflow and our coding conventions. The coding, style, and general engineering guidelines are published on the [Engineering guidelines](https://github.com/dotnet/aspnetcore/wiki/Engineering-guidelines) page.

### Tests
(Exactly As per .Net Core contribution guidelines)

> -  Tests need to be provided for every bug/feature that is completed.
> - Tests only need to be present for issues that need to be verified by QA (for example, not tasks)
> -  If there is a scenario that is far too hard to test there does not need to be a test for it.
>  - "Too hard" is determined by the team as a whole.

### Feedback
(As per .Net Core contribution guidelines)

> Your pull request will now go through extensive checks by the subject matter experts on our team. Please be patient as we're a small team. Update your pull request according to feedback until it is approved by one of the team members. After that, one of our team members may adjust the branch you merge into based on the expected release schedule.

## Code of conduct
(As per .Net Core contribution guidelines)

> This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).  For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.