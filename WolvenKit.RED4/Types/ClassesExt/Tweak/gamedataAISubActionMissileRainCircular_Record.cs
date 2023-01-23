
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionMissileRainCircular_Record
	{
		[RED("maxRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxRadius
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
		
		[RED("missilesPerLaunch")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MissilesPerLaunch
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
