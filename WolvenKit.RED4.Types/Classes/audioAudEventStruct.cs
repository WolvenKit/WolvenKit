using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudEventStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("event")] 
		public CName Event
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
