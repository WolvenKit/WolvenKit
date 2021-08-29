using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entLocalizationStringComponent : entIComponent
	{
		private CArray<entLocalizationStringMapEntry> _strings;

		[Ordinal(3)] 
		[RED("Strings")] 
		public CArray<entLocalizationStringMapEntry> Strings
		{
			get => GetProperty(ref _strings);
			set => SetProperty(ref _strings, value);
		}
	}
}
