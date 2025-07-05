using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttitudePrereq : gameIPrereq
	{
		[Ordinal(0)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		public gameAttitudePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
