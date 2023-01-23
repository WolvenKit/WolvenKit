using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetBooleanArgumentWhenActive : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("booleanArgument")] 
		public CName BooleanArgument
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetBooleanArgumentWhenActive()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
