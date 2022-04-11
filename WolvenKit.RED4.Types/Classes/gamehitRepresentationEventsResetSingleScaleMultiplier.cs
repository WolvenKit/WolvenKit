using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamehitRepresentationEventsResetSingleScaleMultiplier : redEvent
	{
		[Ordinal(0)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
