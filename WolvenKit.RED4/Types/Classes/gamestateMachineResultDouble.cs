using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineResultDouble : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CDouble Value
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineResultDouble()
		{
			Value = 0.000000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
