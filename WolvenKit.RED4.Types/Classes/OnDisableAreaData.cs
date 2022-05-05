using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnDisableAreaData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("agent")] 
		public gamePersistentID Agent
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("remainingAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> RemainingAreas
		{
			get => GetPropertyValue<CArray<CHandle<SecurityAreaControllerPS>>>();
			set => SetPropertyValue<CArray<CHandle<SecurityAreaControllerPS>>>(value);
		}

		public OnDisableAreaData()
		{
			Agent = new();
			RemainingAreas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
