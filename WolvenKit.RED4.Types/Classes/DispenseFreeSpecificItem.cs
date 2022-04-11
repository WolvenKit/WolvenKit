using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DispenseFreeSpecificItem : redEvent
	{
		[Ordinal(0)] 
		[RED("item")] 
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
