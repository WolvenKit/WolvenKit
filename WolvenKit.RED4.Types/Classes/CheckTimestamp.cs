using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckTimestamp : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("validationTime")] 
		public CFloat ValidationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("timestampArgument")] 
		public CName TimestampArgument
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CheckTimestamp()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
