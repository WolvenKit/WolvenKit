
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHudEnhancer_Record
	{
		[RED("coneAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ConeAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
