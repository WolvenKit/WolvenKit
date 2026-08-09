# Pull Requests

## Target Branch
All pull requests should be targeting the main branch.
Changes to dev without an associated pull request towards main should be avoided.^[The pull request towards main can be a draft]

Any PR branch may be merged into the dev branch (nightly) at any time by a maintainer without a separate pull request or review, when this is done the 'nightly' tag should be applied. <br>
Subsequent changes should be added to the pull request targeting main and merged or cherry picked into dev. <br>
Once the pull request has been reviewed and merged into the main branch it will be automatically synced into the dev branch.^[When there are no merge conflicts]

## Description
The description is for the communication between the reviewee and the reviewers. <br>
It doesn't have to contain all of the following aspects however addressing them will speed up the review process and a reviewer may request you to provide them at their descretion.

**Descriptive Title** <br>
Titles should contain the type and content of the change. Someone only reading the title should be able to understand what the pull request is about. <br>
*Positive Examples:* "Fixed XYZ bug", "Updated CI to do Y", "Added X service" <br>
*Negative Exmaples:* "Updated XYZ.cs", "changes" <br>

**Change Description** <br>
A description of the changes at a higher abstraction level than the code, including backwards compatibility. A reviewer should be able to understand the general shape of the changes from reading this.

**Reason for the change** <br>
An explanation of why the changes are necessary and what benefit they bring. This point can also be addressed by linking to the issue that the pull request closes.

**Steps to verify** <br>
Steps to observe the changed behavior and a description of the intended behavior for codepaths which do not have test coverage. This point can also be addressed by linking to the issue that the pull request closes.

**Screenshots** <br>
Screenshots of UI changes if applicable.

**Additional Info** <br>
Anything else that is relevant to the review or organizational process, e.g. request merging into dev, conditions for merging, or a specific merge procedure (merge vs squash merge etc.)

## Code Content
Pull requests should follow the [code of conduct](../CODE_OF_CONDUCT) as well as the [developer guide](../DEVELOPER%20GUIDE).

**Change scope** <br>
Each pull request should be limited to a reasonably small set of coherent changes. If changes depend on each other a [stacked pull requests](https://docs.github.com/en/pull-requests/how-tos/stacked-pull-requests) can be used. <br>
Pull requests addressing a small scope are faster and easier to review and ensure unrelated changes don't block each other. The impact of this scales with change size.

**Functionality** <br>
Pull requests or pull request stacks should contain complete changes that address the entire issue they are solving and should not introduce any new issues. If the changes in a pull request uncover or exadurate an exisitng issue it should be resolved as part of the pull request or pull request stack.
::: info
Exceptions can be made in coordination with the reviewer.
:::

**Tests** <br>
Changes should be written with testability in mind. Newly added business logic should include new unit tests.^[When extending existing classes which do not have test coverage adding tests is not a must, but definitely a nice to have] <br>
Pull requests should be passing all tests.

**Backwards compatability** <br>
Breaking changes^[API changes in nuget packages which are not backwards compatible, or additional dependencies (in the case of the App or CLI dependencies that the user must install)] must be disclosed and may delay the merging of the pull request.

**Changelog** <br>
Any pull request that contains user^[For the App, CLI and Unpacker that is the end user, for ModKit, Common, Core and RED4 that is the developer using the nuget packages] relevant changes^[Relevant changes are directly observable by the consumer] should include a changelog entry.
Guidelines for adding to the changelog can be found [here](/contributing/keep-changelog).
::: info
If you are a new contributor and are unsure how to correctly do so, feel free to ask, and you will be assisted.
:::

