using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<StatPrereqListener> Listener
		{
			get => GetPropertyValue<CHandle<StatPrereqListener>>();
			set => SetPropertyValue<CHandle<StatPrereqListener>>(value);
		}
	}
}
