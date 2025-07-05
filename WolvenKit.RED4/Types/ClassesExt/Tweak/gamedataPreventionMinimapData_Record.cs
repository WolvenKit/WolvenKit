
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPreventionMinimapData_Record
	{
		[RED("maxRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
