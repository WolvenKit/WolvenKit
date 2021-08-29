using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetGlobalTvChannel : redEvent
	{
		private TweakDBID _channel;

		[Ordinal(0)] 
		[RED("channel")] 
		public TweakDBID Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}
	}
}
