using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionCrimeWitnessRequest : gameScriptableSystemRequest
	{
		private Vector4 _criminalPosition;

		[Ordinal(0)] 
		[RED("criminalPosition")] 
		public Vector4 CriminalPosition
		{
			get => GetProperty(ref _criminalPosition);
			set => SetProperty(ref _criminalPosition, value);
		}
	}
}
