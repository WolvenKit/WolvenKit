using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineResultString : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamestateMachineResultString()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
