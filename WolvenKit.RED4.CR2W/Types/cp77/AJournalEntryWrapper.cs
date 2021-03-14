using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AJournalEntryWrapper : ABaseWrapper
	{
		private CInt32 _uniqueId;

		[Ordinal(0)] 
		[RED("UniqueId")] 
		public CInt32 UniqueId
		{
			get
			{
				if (_uniqueId == null)
				{
					_uniqueId = (CInt32) CR2WTypeManager.Create("Int32", "UniqueId", cr2w, this);
				}
				return _uniqueId;
			}
			set
			{
				if (_uniqueId == value)
				{
					return;
				}
				_uniqueId = value;
				PropertySet(this);
			}
		}

		public AJournalEntryWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
