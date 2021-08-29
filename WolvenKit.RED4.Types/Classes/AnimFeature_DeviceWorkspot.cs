using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_DeviceWorkspot : animAnimFeature
	{
		private CBool _e3_lockInReferencePose;

		[Ordinal(0)] 
		[RED("e3_lockInReferencePose")] 
		public CBool E3_lockInReferencePose
		{
			get => GetProperty(ref _e3_lockInReferencePose);
			set => SetProperty(ref _e3_lockInReferencePose, value);
		}
	}
}
