using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayMappinController : QuestMappinController
	{
		private CHandle<inkanimProxy> _anim;
		private CBool _isVisibleThroughWalls;

		[Ordinal(33)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		[Ordinal(34)] 
		[RED("isVisibleThroughWalls")] 
		public CBool IsVisibleThroughWalls
		{
			get => GetProperty(ref _isVisibleThroughWalls);
			set => SetProperty(ref _isVisibleThroughWalls, value);
		}

		public GameplayMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
