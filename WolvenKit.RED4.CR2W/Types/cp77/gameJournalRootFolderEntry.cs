using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRootFolderEntry : gameJournalFolderEntry
	{
		private raRef<gameJournalDescriptorResource> _descriptor;

		[Ordinal(2)] 
		[RED("descriptor")] 
		public raRef<gameJournalDescriptorResource> Descriptor
		{
			get
			{
				if (_descriptor == null)
				{
					_descriptor = (raRef<gameJournalDescriptorResource>) CR2WTypeManager.Create("raRef:gameJournalDescriptorResource", "descriptor", cr2w, this);
				}
				return _descriptor;
			}
			set
			{
				if (_descriptor == value)
				{
					return;
				}
				_descriptor = value;
				PropertySet(this);
			}
		}

		public gameJournalRootFolderEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
