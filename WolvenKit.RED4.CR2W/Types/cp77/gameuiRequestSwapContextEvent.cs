using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRequestSwapContextEvent : redEvent
	{
		private CEnum<UIGameContext> _oldContext;
		private CEnum<UIGameContext> _newContext;

		[Ordinal(0)] 
		[RED("oldContext")] 
		public CEnum<UIGameContext> OldContext
		{
			get
			{
				if (_oldContext == null)
				{
					_oldContext = (CEnum<UIGameContext>) CR2WTypeManager.Create("UIGameContext", "oldContext", cr2w, this);
				}
				return _oldContext;
			}
			set
			{
				if (_oldContext == value)
				{
					return;
				}
				_oldContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<UIGameContext> NewContext
		{
			get
			{
				if (_newContext == null)
				{
					_newContext = (CEnum<UIGameContext>) CR2WTypeManager.Create("UIGameContext", "newContext", cr2w, this);
				}
				return _newContext;
			}
			set
			{
				if (_newContext == value)
				{
					return;
				}
				_newContext = value;
				PropertySet(this);
			}
		}

		public gameuiRequestSwapContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
