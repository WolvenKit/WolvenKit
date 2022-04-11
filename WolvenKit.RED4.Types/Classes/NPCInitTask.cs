using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCInitTask : AIbehaviortaskStackScript
	{
		[Ordinal(0)] 
		[RED("preventSkippingDeathAnimation")] 
		public CBool PreventSkippingDeathAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCInitTask()
		{
			PreventSkippingDeathAnimation = true;
		}
	}
}
