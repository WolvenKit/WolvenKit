using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BumpNetrunnerMinigameLevel : gamePlayerScriptableSystemRequest
	{
		private CInt32 _completedMinigameLevel;

		[Ordinal(1)] 
		[RED("completedMinigameLevel")] 
		public CInt32 CompletedMinigameLevel
		{
			get => GetProperty(ref _completedMinigameLevel);
			set => SetProperty(ref _completedMinigameLevel, value);
		}

		public BumpNetrunnerMinigameLevel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
