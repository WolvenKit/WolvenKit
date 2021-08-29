using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AJournalEntryWrapper : ABaseWrapper
	{
		private CInt32 _uniqueId;

		[Ordinal(0)] 
		[RED("UniqueId")] 
		public CInt32 UniqueId
		{
			get => GetProperty(ref _uniqueId);
			set => SetProperty(ref _uniqueId, value);
		}
	}
}
