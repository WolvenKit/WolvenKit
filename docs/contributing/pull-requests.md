# Pull Requests

## Target Branch
All pull requests should be branching off of and targeting the main branch.

Any PR branch may be merged into the dev branch (nightly) at any time without review. Once the pull request has been reviewed and merged into the main branch it will be automatically synced into the dev branch (nightly).

## Content
Pull requests should follow the [code of conduct](../CODE_OF_CONDUCT) as well as the [developer guide](../DEVELOPER%20GUIDE).

Any pull request that contains user relevant changes (for the App and CLI projects that is the end user, for the projects that are also on nuget like Common or ModKit that is the developer using them) must update the changelog under `changelog\!unreleased.yaml`.
Guidelines for adding to the changelog can be found [here](/contributing/keep-changelog).
::: info
If you are a new contributor and are unsure how to correctly do so, feel free to ask, and you will be assisted.
:::

