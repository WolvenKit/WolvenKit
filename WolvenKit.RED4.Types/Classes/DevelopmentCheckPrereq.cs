using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DevelopmentCheckPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("requiredLevel")] 
		public CFloat RequiredLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DevelopmentCheckPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
