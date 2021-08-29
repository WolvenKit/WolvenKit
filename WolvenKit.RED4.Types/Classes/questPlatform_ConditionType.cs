using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPlatform_ConditionType : questISystemConditionType
	{
		private CEnum<questPlatform> _platform;

		[Ordinal(0)] 
		[RED("platform")] 
		public CEnum<questPlatform> Platform
		{
			get => GetProperty(ref _platform);
			set => SetProperty(ref _platform, value);
		}
	}
}
