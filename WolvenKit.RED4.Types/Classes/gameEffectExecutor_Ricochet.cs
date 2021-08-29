using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_Ricochet : gameEffectExecutor
	{
		private gameEffectOutputParameter_Vector _outputRicochetVector;

		[Ordinal(1)] 
		[RED("outputRicochetVector")] 
		public gameEffectOutputParameter_Vector OutputRicochetVector
		{
			get => GetProperty(ref _outputRicochetVector);
			set => SetProperty(ref _outputRicochetVector, value);
		}
	}
}
