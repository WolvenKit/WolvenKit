using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatusEffectPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<StatusEffectPrereqListener> Listener
		{
			get => GetPropertyValue<CHandle<StatusEffectPrereqListener>>();
			set => SetPropertyValue<CHandle<StatusEffectPrereqListener>>(value);
		}
	}
}
