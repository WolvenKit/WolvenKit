using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityAppearance_ConditionType : questIEntityConditionType
	{
		[Ordinal(0)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questEntityAppearance_ConditionType()
		{
			EntityRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
