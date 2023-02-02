using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IncrementArgumentInt : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("argumentIntName")] 
		public CName ArgumentIntName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public IncrementArgumentInt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
