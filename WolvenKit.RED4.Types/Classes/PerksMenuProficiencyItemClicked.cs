using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksMenuProficiencyItemClicked : PerksMenuAttributeItemClicked
	{
		[Ordinal(3)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
