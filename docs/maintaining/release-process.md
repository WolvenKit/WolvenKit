# Release Process

Stable releases are done by (or with the permission of) the project lead and are scheduled to be around the first of every month.

Nightly releases get automatically build and released daily when changes on the `dev` branch are present.

## Verify Version
Ensure the version upgrade conforms to semver in terms of minor and patch, avoid major releases for now.
If the version needs to be changed run the `bump version` action.

## Staging the Changelog
Before running the main `release` workflow `stage changelog` must be run to generate the changelog from the yaml source.
Once the action is finished the changelog can be viewed in the `changelog-staging` branch, where the `CHANGELOG.md`, `compiled-changelog/CHANGELOG.md`, and `compiled-changelog/CHANGELOG.txt` are saved.
At this stage the changelog should be verified and can be manually edited if needed.
::: info
Edits to the intermediate generated files should only include formatting changes.
For content changes edit `changelog/!unreleased.yaml` on the main branch and run `stage changelog` again.
:::

## Releasing
To release for all platforms (Nuget Packages, GitHub, NexusMods), manually trigger the release workflow. It will create a new tag, read the changelog from the previous step, build all assets and release them.

## Post Release
Bump the patch version by one (e.g., if the stable release was `8.17.2` bump it to `8.17.3`) for the nightly builds.

Post the changelog from the GitHub release in the `#updates` channel on the redmodding discord with links to all platforms and a ping to the `@Server-Participation` role.
