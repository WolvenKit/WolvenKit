using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entTemplateInclude : RedBaseClass
	{
		private CName _name;
		private CResourceAsyncReference<entEntityTemplate> _template;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public CResourceAsyncReference<entEntityTemplate> Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}
	}
}
