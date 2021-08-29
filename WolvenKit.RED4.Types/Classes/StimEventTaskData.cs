using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimEventTaskData : gameScriptTaskData
	{
		private CHandle<senseStimuliEvent> _cachedEvt;

		[Ordinal(0)] 
		[RED("cachedEvt")] 
		public CHandle<senseStimuliEvent> CachedEvt
		{
			get => GetProperty(ref _cachedEvt);
			set => SetProperty(ref _cachedEvt, value);
		}
	}
}
