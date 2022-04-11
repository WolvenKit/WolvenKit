using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PhotomodeFacial : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("facialPoseIndex")] 
		public CInt32 FacialPoseIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
