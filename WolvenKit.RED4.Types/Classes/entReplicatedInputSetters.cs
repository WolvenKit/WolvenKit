using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entReplicatedInputSetters : RedBaseClass
	{
		private netTime _serverReplicatedTime;

		[Ordinal(0)] 
		[RED("serverReplicatedTime")] 
		public netTime ServerReplicatedTime
		{
			get => GetProperty(ref _serverReplicatedTime);
			set => SetProperty(ref _serverReplicatedTime, value);
		}
	}
}
