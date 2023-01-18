using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterFleeingNPC : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("runner")] 
		public CWeakHandle<entEntity> Runner
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public UnregisterFleeingNPC()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
