using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetReactionDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _exitReactionFlag;
		private gamebbScriptID_Bool _blockReactionFlag;

		[Ordinal(0)] 
		[RED("exitReactionFlag")] 
		public gamebbScriptID_Bool ExitReactionFlag
		{
			get
			{
				if (_exitReactionFlag == null)
				{
					_exitReactionFlag = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "exitReactionFlag", cr2w, this);
				}
				return _exitReactionFlag;
			}
			set
			{
				if (_exitReactionFlag == value)
				{
					return;
				}
				_exitReactionFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blockReactionFlag")] 
		public gamebbScriptID_Bool BlockReactionFlag
		{
			get
			{
				if (_blockReactionFlag == null)
				{
					_blockReactionFlag = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "blockReactionFlag", cr2w, this);
				}
				return _blockReactionFlag;
			}
			set
			{
				if (_blockReactionFlag == value)
				{
					return;
				}
				_blockReactionFlag = value;
				PropertySet(this);
			}
		}

		public PuppetReactionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
