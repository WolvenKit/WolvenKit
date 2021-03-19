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
			get => GetProperty(ref _gameTime);
			set => SetProperty(ref _gameTime, value);
		}

		public GameTimeWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
