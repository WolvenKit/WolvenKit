using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalRootFolderEntry : gameJournalFolderEntry
	{
		private CResourceAsyncReference<gameJournalDescriptorResource> _descriptor;

		[Ordinal(2)] 
		[RED("descriptor")] 
		public CResourceAsyncReference<gameJournalDescriptorResource> Descriptor
		{
			get => GetProperty(ref _descriptor);
			set => SetProperty(ref _descriptor, value);
		}
	}
}
