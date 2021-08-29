using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCameraCurvesLibrary : entEntity
	{
		private CArray<CResourceReference<gameCameraCurveSet>> _cameraCurves;

		[Ordinal(2)] 
		[RED("cameraCurves")] 
		public CArray<CResourceReference<gameCameraCurveSet>> CameraCurves
		{
			get => GetProperty(ref _cameraCurves);
			set => SetProperty(ref _cameraCurves, value);
		}
	}
}
