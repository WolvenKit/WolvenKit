using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForcedRagdollDeathSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForcedRagdollDeathSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
