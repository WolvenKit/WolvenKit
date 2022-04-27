
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBox_Record
	{
		[RED("detectionMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("max")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Max
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("min")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Min
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
