
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLinearAccuracy_Record
	{
		[RED("accuracyDropCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat AccuracyDropCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDistanceToRunCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistanceToRunCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
