using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFacialSetup_PosesBufferInfo : RedBaseClass
	{
		private animFacialSetup_OneSermoPoseBufferInfo _face;
		private animFacialSetup_OneSermoPoseBufferInfo _tongue;
		private animFacialSetup_OneSermoPoseBufferInfo _eyes;

		[Ordinal(0)] 
		[RED("face")] 
		public animFacialSetup_OneSermoPoseBufferInfo Face
		{
			get => GetProperty(ref _face);
			set => SetProperty(ref _face, value);
		}

		[Ordinal(1)] 
		[RED("tongue")] 
		public animFacialSetup_OneSermoPoseBufferInfo Tongue
		{
			get => GetProperty(ref _tongue);
			set => SetProperty(ref _tongue, value);
		}

		[Ordinal(2)] 
		[RED("eyes")] 
		public animFacialSetup_OneSermoPoseBufferInfo Eyes
		{
			get => GetProperty(ref _eyes);
			set => SetProperty(ref _eyes, value);
		}
	}
}
