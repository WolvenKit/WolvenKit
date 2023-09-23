using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionCrimeWitnessRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("criminalPosition")] 
		public Vector4 CriminalPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public PreventionCrimeWitnessRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
