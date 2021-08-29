using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSpeedSplineNodeOrientationChangeSection : RedBaseClass
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
	}
}
