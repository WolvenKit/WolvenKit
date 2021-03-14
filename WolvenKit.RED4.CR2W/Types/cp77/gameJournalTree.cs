using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalTree : ISerializable
	{
		private CArray<CHandle<gameJournalRootFolderEntry>> _rootEntries;

		[Ordinal(0)] 
		[RED("rootEntries")] 
		public CArray<CHandle<gameJournalRootFolderEntry>> RootEntries
		{
			get
			{
				if (_rootEntries == null)
				{
					_rootEntries = (CArray<CHandle<gameJournalRootFolderEntry>>) CR2WTypeManager.Create("array:handle:gameJournalRootFolderEntry", "rootEntries", cr2w, this);
				}
				return _rootEntries;
			}
			set
			{
				if (_rootEntries == value)
				{
					return;
				}
				_rootEntries = value;
				PropertySet(this);
			}
		}

		public gameJournalTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
