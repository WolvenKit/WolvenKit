using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSpeedSplineNodeOrientationChangeSection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pos")] 
		public CFloat Pos
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<worldSpeedSplineOrientationMarkerType> Type
		{
			get => GetPropertyValue<CEnum<worldSpeedSplineOrientationMarkerType>>();
			set => SetPropertyValue<CEnum<worldSpeedSplineOrientationMarkerType>>(value);
		}

		[Ordinal(2)] 
		[RED("targetOrientation")] 
		public EulerAngles TargetOrientation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		public worldSpeedSplineNodeOrientationChangeSection()
		{
			TargetOrientation = new EulerAngles();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
