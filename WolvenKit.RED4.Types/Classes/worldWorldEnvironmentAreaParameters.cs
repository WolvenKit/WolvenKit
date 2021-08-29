using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldWorldEnvironmentAreaParameters : RedBaseClass
	{
		private CBool _enable;
		private worldWorldGlobalLightParameters _globalLight;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("globalLight")] 
		public worldWorldGlobalLightParameters GlobalLight
		{
			get => GetProperty(ref _globalLight);
			set => SetProperty(ref _globalLight, value);
		}
	}
}
