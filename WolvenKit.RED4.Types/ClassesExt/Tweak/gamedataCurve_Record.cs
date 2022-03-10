
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCurve_Record
	{
		[RED("curveName")]
		[REDProperty(IsIgnored = true)]
		public CName CurveName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("curveSetName")]
		[REDProperty(IsIgnored = true)]
		public CName CurveSetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
