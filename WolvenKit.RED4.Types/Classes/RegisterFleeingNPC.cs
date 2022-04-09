using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterFleeingNPC : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("runner")] 
		public CWeakHandle<entEntity> Runner
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RegisterFleeingNPC()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
