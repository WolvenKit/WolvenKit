using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CentaurShieldStateChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<ECentaurShieldState> NewState
		{
			get => GetPropertyValue<CEnum<ECentaurShieldState>>();
			set => SetPropertyValue<CEnum<ECentaurShieldState>>(value);
		}
	}
}
