using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimEventTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("cachedEvt")] 
		public CHandle<senseStimuliEvent> CachedEvt
		{
			get => GetPropertyValue<CHandle<senseStimuliEvent>>();
			set => SetPropertyValue<CHandle<senseStimuliEvent>>(value);
		}
	}
}
