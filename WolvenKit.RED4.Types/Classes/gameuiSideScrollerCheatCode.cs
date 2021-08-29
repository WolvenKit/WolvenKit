using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSideScrollerCheatCode : RedBaseClass
	{
		private CName _name;
		private CArray<CName> _keys;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("keys")] 
		public CArray<CName> Keys
		{
			get => GetProperty(ref _keys);
			set => SetProperty(ref _keys, value);
		}
	}
}
