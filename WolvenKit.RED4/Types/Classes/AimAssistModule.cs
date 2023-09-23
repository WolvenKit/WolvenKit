using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AimAssistModule : HUDModule
	{
		[Ordinal(3)] 
		[RED("activeAssists")] 
		public CArray<CHandle<AimAssist>> ActiveAssists
		{
			get => GetPropertyValue<CArray<CHandle<AimAssist>>>();
			set => SetPropertyValue<CArray<CHandle<AimAssist>>>(value);
		}

		public AimAssistModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
