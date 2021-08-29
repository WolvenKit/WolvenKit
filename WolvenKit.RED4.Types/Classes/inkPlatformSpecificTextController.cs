using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPlatformSpecificTextController : inkWidgetLogicController
	{
		private CName _textLocKey;
		private CName _textLocKey_PS4;
		private CName _textLocKey_XB1;

		[Ordinal(1)] 
		[RED("textLocKey")] 
		public CName TextLocKey
		{
			get => GetProperty(ref _textLocKey);
			set => SetProperty(ref _textLocKey, value);
		}

		[Ordinal(2)] 
		[RED("textLocKey_PS4")] 
		public CName TextLocKey_PS4
		{
			get => GetProperty(ref _textLocKey_PS4);
			set => SetProperty(ref _textLocKey_PS4, value);
		}

		[Ordinal(3)] 
		[RED("textLocKey_XB1")] 
		public CName TextLocKey_XB1
		{
			get => GetProperty(ref _textLocKey_XB1);
			set => SetProperty(ref _textLocKey_XB1, value);
		}
	}
}
