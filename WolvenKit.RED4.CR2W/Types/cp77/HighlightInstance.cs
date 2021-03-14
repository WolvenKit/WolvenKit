using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightInstance : ModuleInstance
	{
		private CEnum<HighlightContext> _context;
		private CBool _instant;

		[Ordinal(6)] 
		[RED("context")] 
		public CEnum<HighlightContext> Context
		{
			get
			{
				if (_context == null)
				{
					_context = (CEnum<HighlightContext>) CR2WTypeManager.Create("HighlightContext", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("instant")] 
		public CBool Instant
		{
			get
			{
				if (_instant == null)
				{
					_instant = (CBool) CR2WTypeManager.Create("Bool", "instant", cr2w, this);
				}
				return _instant;
			}
			set
			{
				if (_instant == value)
				{
					return;
				}
				_instant = value;
				PropertySet(this);
			}
		}

		public HighlightInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
