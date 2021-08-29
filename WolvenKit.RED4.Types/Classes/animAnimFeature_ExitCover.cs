using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_ExitCover : animAnimFeature_AIAction
	{
		private CInt32 _coverStance;
		private CInt32 _coverExitDirection;

		[Ordinal(4)] 
		[RED("coverStance")] 
		public CInt32 CoverStance
		{
			get => GetProperty(ref _coverStance);
			set => SetProperty(ref _coverStance, value);
		}

		[Ordinal(5)] 
		[RED("coverExitDirection")] 
		public CInt32 CoverExitDirection
		{
			get => GetProperty(ref _coverExitDirection);
			set => SetProperty(ref _coverExitDirection, value);
		}
	}
}
