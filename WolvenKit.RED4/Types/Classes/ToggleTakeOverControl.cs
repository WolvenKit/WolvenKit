using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleTakeOverControl : ActionBool
	{
		[Ordinal(38)] 
		[RED("isRequestedFormOtherDevice")] 
		public CBool IsRequestedFormOtherDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleTakeOverControl()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
