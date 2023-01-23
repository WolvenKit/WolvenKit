using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInputAction_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("anyInputAction")] 
		public CBool AnyInputAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("inputAction")] 
		public CName InputAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("checkIfButtonAlreadyPressed")] 
		public CBool CheckIfButtonAlreadyPressed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("axisAction")] 
		public CBool AxisAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("valueLessThan")] 
		public CFloat ValueLessThan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("valueMoreThan")] 
		public CFloat ValueMoreThan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questInputAction_ConditionType()
		{
			ValueLessThan = 1.000000F;
			ValueMoreThan = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
