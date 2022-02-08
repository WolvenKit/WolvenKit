using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AJournalEntryWrapper : ABaseWrapper
	{
		[Ordinal(0)] 
		[RED("UniqueId")] 
		public CInt32 UniqueId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
