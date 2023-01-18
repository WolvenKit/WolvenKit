
namespace WolvenKit.RED4.Types
{
	public partial class gamedataChatterHelperRadius_Record
	{
		[RED("maxDistanceToOtherPlayer")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDistanceToOtherPlayer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDistanceToOtherPlayer")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistanceToOtherPlayer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
