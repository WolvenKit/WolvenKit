using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeOrientationChangeSection : CVariable
	{
		private CFloat _pos;
		private CEnum<worldSpeedSplineOrientationMarkerType> _type;
		private EulerAngles _targetOrientation;

		[Ordinal(0)] 
		[RED("pos")] 
		public CFloat Pos
		{
			get => GetProperty(ref _pos);
			set => SetProperty(ref _pos, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<worldSpeedSplineOrientationMarkerType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("targetOrientation")] 
		public EulerAngles TargetOrientation
		{
			get => GetProperty(ref _targetOrientation);
			set => SetProperty(ref _targetOrientation, value);
		}

		public worldSpeedSplineNodeOrientationChangeSection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
