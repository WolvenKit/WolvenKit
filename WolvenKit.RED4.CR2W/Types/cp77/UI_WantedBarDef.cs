using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_WantedBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _currentBounty;
		private gamebbScriptID_Int32 _currentWantedLevel;

		[Ordinal(0)] 
		[RED("CurrentBounty")] 
		public gamebbScriptID_Int32 CurrentBounty
		{
			get
			{
				if (_currentBounty == null)
				{
					_currentBounty = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "CurrentBounty", cr2w, this);
				}
				return _currentBounty;
			}
			set
			{
				if (_currentBounty == value)
				{
					return;
				}
				_currentBounty = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("CurrentWantedLevel")] 
		public gamebbScriptID_Int32 CurrentWantedLevel
		{
			get
			{
				if (_currentWantedLevel == null)
				{
					_currentWantedLevel = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "CurrentWantedLevel", cr2w, this);
				}
				return _currentWantedLevel;
			}
			set
			{
				if (_currentWantedLevel == value)
				{
					return;
				}
				_currentWantedLevel = value;
				PropertySet(this);
			}
		}

		public UI_WantedBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
