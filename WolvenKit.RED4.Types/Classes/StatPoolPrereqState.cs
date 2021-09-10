using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<BaseStatPoolPrereqListener> Listener
		{
			get => GetPropertyValue<CHandle<BaseStatPoolPrereqListener>>();
			set => SetPropertyValue<CHandle<BaseStatPoolPrereqListener>>(value);
		}
	}
}
