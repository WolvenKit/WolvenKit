import { defineConfig } from 'vitepress'

// https://vitepress.dev/reference/site-config
export default defineConfig({
  title: "WolvenKit Developer Documentation",
  description: "Everything you need to know about contributing to the WolvenKit project.",
  base: '/WolvenKit/',
  themeConfig: {
    // https://vitepress.dev/reference/default-theme-config
    nav: [
      { text: 'Home', link: '/' }
    ],

    sidebar: [
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
