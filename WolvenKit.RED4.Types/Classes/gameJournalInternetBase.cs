using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalInternetBase : IScriptable
	{
		private CName _name;
		private CString _linkAddress;
		private CColor _tintColor;
		private CColor _hoverTintColor;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("linkAddress")] 
		public CString LinkAddress
		{
			get => GetProperty(ref _linkAddress);
			set => SetProperty(ref _linkAddress, value);
		}

		[Ordinal(2)] 
		[RED("tintColor")] 
		public CColor TintColor
		{
			get => GetProperty(ref _tintColor);
			set => SetProperty(ref _tintColor, value);
		}

		[Ordinal(3)] 
		[RED("hoverTintColor")] 
		public CColor HoverTintColor
		{
			get => GetProperty(ref _hoverTintColor);
			set => SetProperty(ref _hoverTintColor, value);
		}
	}
}
