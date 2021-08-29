using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckTimestamp : AIbehaviorconditionScript
	{
		private CFloat _validationTime;
		private CName _timestampArgument;

		[Ordinal(0)] 
		[RED("validationTime")] 
		public CFloat ValidationTime
		{
			get => GetProperty(ref _validationTime);
			set => SetProperty(ref _validationTime, value);
		}

		[Ordinal(1)] 
		[RED("timestampArgument")] 
		public CName TimestampArgument
		{
			get => GetProperty(ref _timestampArgument);
			set => SetProperty(ref _timestampArgument, value);
		}
	}
}
