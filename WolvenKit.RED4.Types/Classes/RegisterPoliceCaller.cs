using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterPoliceCaller : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("caller")] 
		public CWeakHandle<entEntity> Caller
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("crimePosition")] 
		public Vector4 CrimePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public RegisterPoliceCaller()
		{
			CrimePosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
