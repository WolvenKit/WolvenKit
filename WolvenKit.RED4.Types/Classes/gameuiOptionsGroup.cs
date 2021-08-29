using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiOptionsGroup : RedBaseClass
	{
		private CName _name;
		private CArray<CName> _options;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("options")] 
		public CArray<CName> Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}
	}
}
