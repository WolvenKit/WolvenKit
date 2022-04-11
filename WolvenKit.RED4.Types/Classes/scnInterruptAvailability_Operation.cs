using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterruptAvailability_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnInterruptAvailability_Operation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
