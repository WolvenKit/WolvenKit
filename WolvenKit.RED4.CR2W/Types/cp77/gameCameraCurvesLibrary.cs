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
			get
			{
				if (_cameraCurves == null)
				{
					_cameraCurves = (CArray<rRef<gameCameraCurveSet>>) CR2WTypeManager.Create("array:rRef:gameCameraCurveSet", "cameraCurves", cr2w, this);
				}
				return _cameraCurves;
			}
			set
			{
				if (_cameraCurves == value)
				{
					return;
				}
				_cameraCurves = value;
				PropertySet(this);
			}
		}

		public gameCameraCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
