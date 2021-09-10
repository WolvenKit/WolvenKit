using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalEntryNotificationRemoveRequestData : IScriptable
	{
		[Ordinal(0)] 
		[RED("entryHash")] 
		public CUInt32 EntryHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
