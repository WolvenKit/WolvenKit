using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entLocalizationStringMapEntry : RedBaseClass
	{
		private CName _key;
		private LocalizationString _string;

		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("string")] 
		public LocalizationString String
		{
			get => GetProperty(ref _string);
			set => SetProperty(ref _string, value);
		}
	}
}
