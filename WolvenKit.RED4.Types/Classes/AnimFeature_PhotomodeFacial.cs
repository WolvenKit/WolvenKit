using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PhotomodeFacial : animAnimFeature
	{
		private CInt32 _facialPoseIndex;

		[Ordinal(0)] 
		[RED("facialPoseIndex")] 
		public CInt32 FacialPoseIndex
		{
			get => GetProperty(ref _facialPoseIndex);
			set => SetProperty(ref _facialPoseIndex, value);
		}
	}
}
