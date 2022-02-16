using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SandevistanDecisions : TimeDilationTransitions
	{
		[Ordinal(0)] 
		[RED("statListener")] 
		public CHandle<DefaultTransitionStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatListener>>(value);
		}
	}
}
