using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakFenceSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hasGenericInteraction")] 
		public CBool HasGenericInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WeakFenceSetup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
