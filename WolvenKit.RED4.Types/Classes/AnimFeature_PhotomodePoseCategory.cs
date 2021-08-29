using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_PhotomodePoseCategory : animAnimFeature
	{
		private CInt32 _poseCategoryIndex;

		[Ordinal(0)] 
		[RED("poseCategoryIndex")] 
		public CInt32 PoseCategoryIndex
		{
			get => GetProperty(ref _poseCategoryIndex);
			set => SetProperty(ref _poseCategoryIndex, value);
		}
	}
}
