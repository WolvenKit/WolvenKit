using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_KillFX : gameEffectAction
	{
		private CEnum<gameEffectAction_KillFXAction> _action;
		private CName _effectTag;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gameEffectAction_KillFXAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<gameEffectAction_KillFXAction>) CR2WTypeManager.Create("gameEffectAction_KillFXAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get
			{
				if (_effectTag == null)
				{
					_effectTag = (CName) CR2WTypeManager.Create("CName", "effectTag", cr2w, this);
				}
				return _effectTag;
			}
			set
			{
				if (_effectTag == value)
				{
					return;
				}
				_effectTag = value;
				PropertySet(this);
			}
		}

		public gameEffectAction_KillFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
