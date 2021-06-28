using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTimeSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CBool _paused;
		private GameTime _gameTime;

		[Ordinal(0)] 
		[RED("paused")] 
		public CBool Paused
		{
			get => GetProperty(ref _paused);
			set => SetProperty(ref _paused, value);
		}

		[Ordinal(1)] 
		[RED("gameTime")] 
		public GameTime GameTime
		{
			get => GetProperty(ref _gameTime);
			set => SetProperty(ref _gameTime, value);
		}

		public gameTimeSystemReplicatedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
