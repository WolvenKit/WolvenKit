using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModePrereq : gameIPrereq
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get => GetPropertyValue<CEnum<gameVisionModeType>>();
			set => SetPropertyValue<CEnum<gameVisionModeType>>(value);
		}

		public gameVisionModePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
