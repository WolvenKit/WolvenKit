using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddActiveContextEvent : redEvent
	{
		private CEnum<gamedeviceRequestType> _context;

		[Ordinal(0)] 
		[RED("context")] 
		public CEnum<gamedeviceRequestType> Context
		{
			get
			{
				if (_context == null)
				{
					_context = (CEnum<gamedeviceRequestType>) CR2WTypeManager.Create("gamedeviceRequestType", "context", cr2w, this);
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

		public AddActiveContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
