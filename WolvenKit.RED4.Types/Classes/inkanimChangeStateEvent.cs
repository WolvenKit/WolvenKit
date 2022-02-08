using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimChangeStateEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CName State
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
