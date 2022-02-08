using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalRootFolderEntry : gameJournalFolderEntry
	{
		[Ordinal(2)] 
		[RED("descriptor")] 
		public CResourceAsyncReference<gameJournalDescriptorResource> Descriptor
		{
			get => GetPropertyValue<CResourceAsyncReference<gameJournalDescriptorResource>>();
			set => SetPropertyValue<CResourceAsyncReference<gameJournalDescriptorResource>>(value);
		}
	}
}
