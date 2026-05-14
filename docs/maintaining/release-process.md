# Release Process

Stable releases are done by (or with the permission of) the project lead and are expected to be performed the first of every month.

Nightly releases get automatically build and released daily when changes on the `dev` branch are present.

## Verify Version
Ensure the version upgrade conforms to semver in terms of minor and patch. Major releases should be planned ahead of time to bundle breaking changes and leave enough time for users to move off of deprecated features.

If the version needs to be changed run the `bump version` action.

## Generate the Changelog
Before running the `release` workflow the `state changelog` action must be run to generate a pull request containing the user facing changelog based on the yaml source.
This pull request needs to be validated and merged into the main branch before the release workflow can be run.
::: info
Edits to the generated files should only include formatting changes.
For content changes edit `changelog/!unreleased.yaml` on the main branch and run `stage changelog` again.
:::

## Release
To release for all platforms (Nuget Packages, GitHub, NexusMods), manually trigger the release workflow. It will create a new tag, read the changelog from the previous step, build all assets and release them.

## Post Release
Bump the patch version by one (e.g., if the stable release was `8.17.2` bump it to `8.17.3`) for the nightly builds.

Post the changelog from the GitHub release in the `#updates` channel on the redmodding discord with links to all platforms and a ping to the `@Server-Participation` role.
