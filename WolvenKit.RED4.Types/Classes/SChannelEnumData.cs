using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SChannelEnumData : RedBaseClass
	{
		private CEnum<ETVChannel> _channel;

		[Ordinal(0)] 
		[RED("channel")] 
		public CEnum<ETVChannel> Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}
	}
}
