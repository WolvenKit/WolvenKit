using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISquadBlackBoardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _barkPlayed;
		private gamebbScriptID_Bool _lowHealthBarkPlayed;
		private gamebbScriptID_Float _barkPlayedTimeStamp;

		[Ordinal(0)] 
		[RED("BarkPlayed")] 
		public gamebbScriptID_Bool BarkPlayed
		{
			get
			{
				if (_barkPlayed == null)
				{
					_barkPlayed = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "BarkPlayed", cr2w, this);
				}
				return _barkPlayed;
			}
			set
			{
				if (_barkPlayed == value)
				{
					return;
				}
				_barkPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("LowHealthBarkPlayed")] 
		public gamebbScriptID_Bool LowHealthBarkPlayed
		{
			get
			{
				if (_lowHealthBarkPlayed == null)
				{
					_lowHealthBarkPlayed = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "LowHealthBarkPlayed", cr2w, this);
				}
				return _lowHealthBarkPlayed;
			}
			set
			{
				if (_lowHealthBarkPlayed == value)
				{
					return;
				}
				_lowHealthBarkPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("BarkPlayedTimeStamp")] 
		public gamebbScriptID_Float BarkPlayedTimeStamp
		{
			get
			{
				if (_barkPlayedTimeStamp == null)
				{
					_barkPlayedTimeStamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "BarkPlayedTimeStamp", cr2w, this);
				}
				return _barkPlayedTimeStamp;
			}
			set
			{
				if (_barkPlayedTimeStamp == value)
				{
					return;
				}
				_barkPlayedTimeStamp = value;
				PropertySet(this);
			}
		}

		public AISquadBlackBoardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
