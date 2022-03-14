
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCone_Record
	{
		[RED("detectionMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("position1")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Position1
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("position2")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Position2
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("radius1")]
		[REDProperty(IsIgnored = true)]
		public CFloat Radius1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("radius2")]
		[REDProperty(IsIgnored = true)]
		public CFloat Radius2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
