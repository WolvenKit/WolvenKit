using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCameraCurvesLibrary : entEntity
	{
		private CArray<rRef<gameCameraCurveSet>> _cameraCurves;

		[Ordinal(2)] 
		[RED("cameraCurves")] 
		public CArray<rRef<gameCameraCurveSet>> CameraCurves
		{
			get => GetProperty(ref _cameraCurves);
			set => SetProperty(ref _cameraCurves, value);
		}

		public gameCameraCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
