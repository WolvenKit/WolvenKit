using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackDataEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get => GetPropertyValue<CHandle<QuickhackData>>();
			set => SetPropertyValue<CHandle<QuickhackData>>(value);
		}
	}
}
