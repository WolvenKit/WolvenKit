using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityTimePeriod : RedBaseClass
	{
		private CEnum<communityECommunitySpawnTime> _hour;

		[Ordinal(0)] 
		[RED("hour")] 
		public CEnum<communityECommunitySpawnTime> Hour
		{
			get => GetProperty(ref _hour);
			set => SetProperty(ref _hour, value);
		}
	}
}
