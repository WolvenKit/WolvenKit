# Keep a Changelog

Our changelog rules generally  follow [keepachangelog.com](https://keepachangelog.com/en/1.1.0/).

This project keeps the unreleased changes in yaml format under `changelog/unreleased` where each file represents an individual pull request. The file name is the pull request number.
::: warning

All other files in the `changelog` directory should not be manually modified as they are generated.
While `changelog/!unreleased.yaml` will consider changes added to it directly, it should be avoided due to the high risk of merge conflicts.

:::

To add a new changelog entry make a copy of the `changelog/!template.yaml` file under `changelog/unreleased/{PR_NUMBER}.yaml` and add as many entries as needed to the `changes:` array.

Each changes entry follows the following format:
```yaml
# This can be either `security`, `deprecated`, `removed`, `added`, `fixed`, or `changed`.
# Pick one.
- type: "security | deprecated | removed | added | fixed | changed"
    # List of projects that were affected by the given change. Changes in nuget packages should include `App` and `CLI`.
    # `Core`, `Common`, `RED4` and `Modkit` are considered nuget packages.
    # Pick as many as apply.
    packages: ["App", "CLI", "Nuget Packages"]
    # Pull request number(s) associated with this change.
    # Accepts a single number or a list when several PRs contributed to the change.
    pr-number: 0
    # GitHub username(s) of the author(s), necessary for proper attribution.
    # Accepts a single name or a list; all authors are credited in the changelog.
    author: ""
    # User facing change description
    description: ""
```
