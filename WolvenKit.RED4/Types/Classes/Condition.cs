using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Condition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("passed")] 
		public CBool Passed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public Condition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
