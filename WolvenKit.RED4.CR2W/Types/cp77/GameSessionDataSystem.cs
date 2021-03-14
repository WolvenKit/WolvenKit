using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameSessionDataSystem : gameScriptableSystem
	{
		private CArray<CHandle<GameSessionDataModule>> _gameSessionDataModules;

		[Ordinal(0)] 
		[RED("gameSessionDataModules")] 
		public CArray<CHandle<GameSessionDataModule>> GameSessionDataModules
		{
			get
			{
				if (_gameSessionDataModules == null)
				{
					_gameSessionDataModules = (CArray<CHandle<GameSessionDataModule>>) CR2WTypeManager.Create("array:handle:GameSessionDataModule", "gameSessionDataModules", cr2w, this);
				}
				return _gameSessionDataModules;
			}
			set
			{
				if (_gameSessionDataModules == value)
				{
					return;
				}
				_gameSessionDataModules = value;
				PropertySet(this);
			}
		}

		public GameSessionDataSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
