using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PhotomodePoseCategory : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("poseCategoryIndex")] 
		public CInt32 PoseCategoryIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
