using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterTransporterSpawnData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("aiType")] 
		public CEnum<gameuiarcadeShooterAIType> AiType
		{
			get => GetPropertyValue<CEnum<gameuiarcadeShooterAIType>>();
			set => SetPropertyValue<CEnum<gameuiarcadeShooterAIType>>(value);
		}

		[Ordinal(1)] 
		[RED("parameter")] 
		public CName Parameter
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiarcadeShooterTransporterSpawnData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
