# Keep a Changelog

Our changelog rules generally follow [keepachangelog.com](https://keepachangelog.com/en/1.1.0/).

This project keeps the changelog in `.yaml` files within the `changelog` directory. The `!unreleased.yaml` file contains changes that are merged into main but have not been part of a stable release yet.
::: info
This is the file that is modified as part of the pull request process.
:::
::: warning
`CHANGELOG.md` as well as `{VERSION}.yaml` files are auto generated as part of the release process and should not be manually modified.
:::

Each changelog entry should be added to the `changes:` array in the `!unreleased.yaml` file where each entry has the follwing structure:

```yaml
# This can be either `security`, `deprecated`, `removed`, `added`, `fixed`, or `changed`.
# Pick one.
- type: "security | deprecated | removed | added | fixed | changed"
    # List of projects that were affected by the given change. Changes in nuget packages should include `App` and `CLI`.
    # `Core`, `Common`, `RED4` and `Modkit` are considered nuget packages.
    # Pick as many as apply.
    packages: ["App", "CLI", "Nuget Packages"]
    # Pull request number associated with this change.
    pr-number: 0
    # Authors github username, necessary for proper attribution
    author: ""
    # User facing change description
    description: ""
```
::: info
A Pull request can have multiple changelog entries.
:::

