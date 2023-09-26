using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsMountedByPreventionNPCPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("isCheckInverted")] 
		public CBool IsCheckInverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IsMountedByPreventionNPCPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
