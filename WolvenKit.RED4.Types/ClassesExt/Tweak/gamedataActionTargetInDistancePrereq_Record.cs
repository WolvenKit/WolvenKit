
namespace WolvenKit.RED4.Types
{
	public partial class gamedataActionTargetInDistancePrereq_Record
	{
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
