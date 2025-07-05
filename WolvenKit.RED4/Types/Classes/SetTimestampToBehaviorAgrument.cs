using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetTimestampToBehaviorAgrument : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("timestampArgument")] 
		public CName TimestampArgument
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetTimestampToBehaviorAgrument()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
