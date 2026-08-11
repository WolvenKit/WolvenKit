# Reviewing Pull Requests
The primary goal of a pull request review is to ensure code and application quality. <br>
The description section as defined in [Pull Requests - For Contributors](../contributing/pull-requests) serves the purpose of getting you the reviewer up to speed before reading the changelog.
::: info
Pull requests are not required to contain a dedicated point for each aspect on that list, however if you deem the description to not be adequate you can request it to be expanded.
:::

## Procedure
When reviewing a pull request assign yourself as the reviewer, that way it is clear to the reviewee who is handling the review and to other maintainers that the given pull request is already in review. <br>

Change requests should be detailed, specific and scope aware, for larger non blocking changes consider a follow up pull request. <br>
To reduce unproductive back and forth suggestions should be used for small localized changes, if you have specific larger changes in mind that would be difficult to communicate consider adding a pull request to the stack.

After a pull request has been approved it is the responsbility of the reviewer to merge the pull request. <br>
Prefer a regular merge when the commit history is structured and contains relevant information (e.g. "Implemented XYZ service" "Adjusted consumers to use XYZ service" "Fixed Y bug") and prefer squash merge for commit histories which add little value (e.g. "Updated XYZ.cs" "fix" "changes" "review").

## Content Verification
In order to achieve the stated goal reviewers are expected to review the following aspects:

**Code Style & Patterns** <br>
Verify that the submitted code follows our code style guidelines and that patterns (e.g. DI, dialog setup, responsive UI) are implemented consistently and according to guidelines.

**Functionality** <br>
Verify that the submitted code functions as described and as an end user would expect it to, is an improvement and does not introduce new issues or exaggerate existing ones.
::: info
A pull request with new issues may be approved if the issue can not be resolved on a reasonable timeframe and the change is overall an improvement. Use your judgement to decide. <br>
Such known issues should be immediately documented via an open issue.
:::
Functionality changes must be tested either manually or via our test suit if it is covered. <br>
Often times a combination of manual and automated testing will be necesary.

**Tests** <br>
Verify that newly added or changed tests pass and that they both test a relevant function and that it is tested in a manner in which it is likely to catch issues (e.g. with a high branch coverage).
::: warning
Changed existing tests in combination with functionality changes can be an indicator of a breaking change, if the pull request isn't marked as such double check that it isn't.
:::
**Changelog** <br>
Verify that the changelog is present only when the pull request contains end user relevant changes.
