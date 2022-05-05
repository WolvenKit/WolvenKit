using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_Root_Object : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bool")] 
		public CBool Bool
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Sample_Replicated_Root_Object()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
