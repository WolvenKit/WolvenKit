using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleScreenProjectionGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("OnTargetHitCallback")] 
		public CHandle<redCallbackObject> OnTargetHitCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public sampleScreenProjectionGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
