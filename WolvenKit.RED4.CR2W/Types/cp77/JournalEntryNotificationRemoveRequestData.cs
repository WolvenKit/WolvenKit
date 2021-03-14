using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalEntryNotificationRemoveRequestData : IScriptable
	{
		private CUInt32 _entryHash;

		[Ordinal(0)] 
		[RED("entryHash")] 
		public CUInt32 EntryHash
		{
			get
			{
				if (_entryHash == null)
				{
					_entryHash = (CUInt32) CR2WTypeManager.Create("Uint32", "entryHash", cr2w, this);
				}
				return _entryHash;
			}
			set
			{
				if (_entryHash == value)
				{
					return;
				}
				_entryHash = value;
				PropertySet(this);
			}
		}

		public JournalEntryNotificationRemoveRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
