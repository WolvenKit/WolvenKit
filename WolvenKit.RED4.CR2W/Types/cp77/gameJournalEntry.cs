using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntry : IScriptable
	{
		private CString _id;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CString) CR2WTypeManager.Create("String", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public gameJournalEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
