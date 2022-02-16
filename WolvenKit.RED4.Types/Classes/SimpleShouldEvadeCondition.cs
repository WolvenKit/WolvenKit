using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleShouldEvadeCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("hitReactionComponent")] 
		public CHandle<HitReactionComponent> HitReactionComponent
		{
			get => GetPropertyValue<CHandle<HitReactionComponent>>();
			set => SetPropertyValue<CHandle<HitReactionComponent>>(value);
		}
	}
}
