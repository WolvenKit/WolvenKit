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
			get
			{
				if (_paused == null)
				{
					_paused = (CBool) CR2WTypeManager.Create("Bool", "paused", cr2w, this);
				}
				return _paused;
			}
			set
			{
				if (_paused == value)
				{
					return;
				}
				_paused = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameTime")] 
		public GameTime GameTime
		{
			get
			{
				if (_gameTime == null)
				{
					_gameTime = (GameTime) CR2WTypeManager.Create("GameTime", "gameTime", cr2w, this);
				}
				return _gameTime;
			}
			set
			{
				if (_gameTime == value)
				{
					return;
				}
				_gameTime = value;
				PropertySet(this);
			}
		}

		public gameTimeSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
