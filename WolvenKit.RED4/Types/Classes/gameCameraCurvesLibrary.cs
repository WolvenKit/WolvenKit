using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCameraCurvesLibrary : entEntity
	{
		[Ordinal(2)] 
		[RED("cameraCurves")] 
		public CArray<CResourceReference<gameCameraCurveSet>> CameraCurves
		{
			get => GetPropertyValue<CArray<CResourceReference<gameCameraCurveSet>>>();
			set => SetPropertyValue<CArray<CResourceReference<gameCameraCurveSet>>>(value);
		}

		public gameCameraCurvesLibrary()
		{
			CameraCurves = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
