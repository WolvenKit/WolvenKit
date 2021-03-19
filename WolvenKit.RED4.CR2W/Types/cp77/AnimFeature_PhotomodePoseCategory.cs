using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PhotomodePoseCategory : animAnimFeature
	{
		private CInt32 _poseCategoryIndex;

		[Ordinal(0)] 
		[RED("poseCategoryIndex")] 
		public CInt32 PoseCategoryIndex
		{
			get => GetProperty(ref _poseCategoryIndex);
			set => SetProperty(ref _poseCategoryIndex, value);
		}

		public AnimFeature_PhotomodePoseCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
