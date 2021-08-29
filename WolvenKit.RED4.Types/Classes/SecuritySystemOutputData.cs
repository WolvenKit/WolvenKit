using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemOutputData : RedBaseClass
	{
		private DeviceLink _link;
		private CEnum<EBreachOrigin> _breachOrigin;
		private CFloat _delayDuration;

		[Ordinal(0)] 
		[RED("link")] 
		public DeviceLink Link
		{
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(1)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetProperty(ref _breachOrigin);
			set => SetProperty(ref _breachOrigin, value);
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetProperty(ref _delayDuration);
			set => SetProperty(ref _delayDuration, value);
		}
	}
}
