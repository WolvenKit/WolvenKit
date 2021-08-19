using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimEventTaskData : gameScriptTaskData
	{
		private CHandle<senseStimuliEvent> _cachedEvt;

		[Ordinal(0)] 
		[RED("cachedEvt")] 
		public CHandle<senseStimuliEvent> CachedEvt
		{
			get => GetProperty(ref _cachedEvt);
			set => SetProperty(ref _cachedEvt, value);
		}

		public StimEventTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
