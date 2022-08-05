
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRegular_Record
	{
		[RED("startVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startVelocityCharged")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartVelocityCharged
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
