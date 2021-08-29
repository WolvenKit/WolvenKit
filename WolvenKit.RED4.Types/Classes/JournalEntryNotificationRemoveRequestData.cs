using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalEntryNotificationRemoveRequestData : IScriptable
	{
		private CUInt32 _entryHash;

		[Ordinal(0)] 
		[RED("entryHash")] 
		public CUInt32 EntryHash
		{
			get => GetProperty(ref _entryHash);
			set => SetProperty(ref _entryHash, value);
		}
	}
}
