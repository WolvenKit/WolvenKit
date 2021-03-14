using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiContextChangedEvent : redEvent
	{
		private CEnum<gameuiContext> _oldContext;
		private CEnum<gameuiContext> _newContext;

		[Ordinal(0)] 
		[RED("oldContext")] 
		public CEnum<gameuiContext> OldContext
		{
			get
			{
				if (_oldContext == null)
				{
					_oldContext = (CEnum<gameuiContext>) CR2WTypeManager.Create("gameuiContext", "oldContext", cr2w, this);
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
		public CEnum<gameuiContext> NewContext
		{
			get
			{
				if (_newContext == null)
				{
					_newContext = (CEnum<gameuiContext>) CR2WTypeManager.Create("gameuiContext", "newContext", cr2w, this);
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

		public gameuiContextChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
