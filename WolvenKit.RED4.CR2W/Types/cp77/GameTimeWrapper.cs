using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameTimeWrapper : CVariable
	{
		private GameTime _gameTime;

		[Ordinal(0)] 
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

		public GameTimeWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
