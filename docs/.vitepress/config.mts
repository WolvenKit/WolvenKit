import { defineConfig } from 'vitepress'

// https://vitepress.dev/reference/site-config
export default defineConfig({
  title: "WolvenKit Developer Documentation",
  description: "Everything you need to know about contributing to the WolvenKit project.",
  base: '/WolvenKit/',
  ignoreDeadLinks: true,
  head: [
    ['link', { rel: 'icon', href: '/WolvenKit/favicon.ico' }]
  ],
  themeConfig: {
    // https://vitepress.dev/reference/default-theme-config
    nav: [
      { text: 'Home', link: '/' }
    ],

    sidebar: [
      {
        text: 'Summary',
        collapsed: false,
        items: [
          { text: 'Contributing', link: '/CONTRIBUTING' },
          { text: 'Code of Conduct', link: '/CODE_OF_CONDUCT' },
          { text: 'Developer Guide', link: '/DEVELOPER%20GUIDE' },
        ]
      },
      {
        text: 'Meta Documentation',
        collapsed: false,
        items: [
          { text: 'Homepage', link: '/meta-documentation/home' },
          { text: 'Contributing', link: '/meta-documentation/contributing' },
        ]
      },
      {
        text: 'Contributing',
        collapsed: false,
        items: [
          { text: 'Homepage', link: '/contributing/home' },
        ]
      },
      {
        text: 'Code Documentation',
        collapsed: false,
        items: [
          { text: 'Homepage', link: '/code-documentation/home' },
        ]
      }
    ],

    socialLinks: [
      { icon: 'github', link: 'https://github.com/WolvenKit/WolvenKit' }
    ]
  }
})
