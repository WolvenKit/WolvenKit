# Contributing

This documentation uses [vitepress](https://vitepress.dev/) as such it supports markdown with custom extensions as outlined [here](https://vitepress.dev/guide/markdown).

### Writing Changes

To write changes modify the markdown files in `/docs` and follow the regular pull request process to merge the changes into the main branch.

Once the changes are merged the site will be auto deployed.

::: warning
When creating, renaming, moving or deleting files the sidebar config in `/docs/.vitepress/config.mts` should reflect the change.
:::

### Viewing Changes Locally

To view changes locally run the following in a command line interface from the root of the repository.

```bash
cd docs
npm install
npm run docs:dev
```

This will install and run a vitepress instance on your localhost which reflects changes made as the files are saved.

::: info
Viewing changes locally before opening a pull request is strongly recommended as it significantly reduces the chance of broken formatting going live. 
:::