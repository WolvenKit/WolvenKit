using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCHitReactionTypePrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<PuppetListener> Listener
		{
			get => GetPropertyValue<CHandle<PuppetListener>>();
			set => SetPropertyValue<CHandle<PuppetListener>>(value);
		}
	}
}
