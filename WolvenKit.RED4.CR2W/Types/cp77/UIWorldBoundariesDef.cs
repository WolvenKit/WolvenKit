using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIWorldBoundariesDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isPlayerCloseToBoundary;
		private gamebbScriptID_Bool _isPlayerGoingDeeper;

		[Ordinal(0)] 
		[RED("IsPlayerCloseToBoundary")] 
		public gamebbScriptID_Bool IsPlayerCloseToBoundary
		{
			get
			{
				if (_isPlayerCloseToBoundary == null)
				{
					_isPlayerCloseToBoundary = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsPlayerCloseToBoundary", cr2w, this);
				}
				return _isPlayerCloseToBoundary;
			}
			set
			{
				if (_isPlayerCloseToBoundary == value)
				{
					return;
				}
				_isPlayerCloseToBoundary = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IsPlayerGoingDeeper")] 
		public gamebbScriptID_Bool IsPlayerGoingDeeper
		{
			get
			{
				if (_isPlayerGoingDeeper == null)
				{
					_isPlayerGoingDeeper = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsPlayerGoingDeeper", cr2w, this);
				}
				return _isPlayerGoingDeeper;
			}
			set
			{
				if (_isPlayerGoingDeeper == value)
				{
					return;
				}
				_isPlayerGoingDeeper = value;
				PropertySet(this);
			}
		}

		public UIWorldBoundariesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
