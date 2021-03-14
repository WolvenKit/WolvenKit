using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsManager : IScriptable
	{
		private CHandle<gameStatModifierData> _playerGodModeModifierData;

		[Ordinal(0)] 
		[RED("playerGodModeModifierData")] 
		public CHandle<gameStatModifierData> PlayerGodModeModifierData
		{
			get
			{
				if (_playerGodModeModifierData == null)
				{
					_playerGodModeModifierData = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "playerGodModeModifierData", cr2w, this);
				}
				return _playerGodModeModifierData;
			}
			set
			{
				if (_playerGodModeModifierData == value)
				{
					return;
				}
				_playerGodModeModifierData = value;
				PropertySet(this);
			}
		}

		public StatsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
