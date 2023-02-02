
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAngleRange_Record
	{
		[RED("angle")]
		[REDProperty(IsIgnored = true)]
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("halfHeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat HalfHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("position")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
