using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResetReactionEvent : redEvent
	{
		private CHandle<AIReactionData> _data;

		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<AIReactionData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
