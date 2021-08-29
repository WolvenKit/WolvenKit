using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficPersistentData : RedBaseClass
	{
		private CBool _invertTrafficEvents;

		[Ordinal(0)] 
		[RED("invertTrafficEvents")] 
		public CBool InvertTrafficEvents
		{
			get => GetProperty(ref _invertTrafficEvents);
			set => SetProperty(ref _invertTrafficEvents, value);
		}
	}
}
