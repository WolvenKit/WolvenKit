using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetAnyTargetIsLocked : redEvent
	{
		[Ordinal(0)] 
		[RED("wasSeen")] 
		public CBool WasSeen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetAnyTargetIsLocked()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
