using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGameplayActionEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CHandle<scnIGameplayActionData> _gameplayActionData;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("gameplayActionData")] 
		public CHandle<scnIGameplayActionData> GameplayActionData
		{
			get => GetProperty(ref _gameplayActionData);
			set => SetProperty(ref _gameplayActionData, value);
		}

		public scnGameplayActionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
