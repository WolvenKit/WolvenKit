using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFocusClueStateChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameFocusClueStateChangeEvent()
		{
			ClueIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
