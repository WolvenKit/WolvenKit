using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questOpenMessage_NodeType : questIPhoneManagerNodeType
	{
		private CHandle<gameJournalPath> _msg;

		[Ordinal(0)] 
		[RED("msg")] 
		public CHandle<gameJournalPath> Msg
		{
			get
			{
				if (_msg == null)
				{
					_msg = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "msg", cr2w, this);
				}
				return _msg;
			}
			set
			{
				if (_msg == value)
				{
					return;
				}
				_msg = value;
				PropertySet(this);
			}
		}

		public questOpenMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
