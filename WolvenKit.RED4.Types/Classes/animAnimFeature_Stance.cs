using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_Stance : animAnimFeature
	{
		private CInt32 _stanceState;

		[Ordinal(0)] 
		[RED("stanceState")] 
		public CInt32 StanceState
		{
			get => GetProperty(ref _stanceState);
			set => SetProperty(ref _stanceState, value);
		}
	}
}
