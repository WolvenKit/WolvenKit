using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakFenceSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hasGenericInteraction")] 
		public CBool HasGenericInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
