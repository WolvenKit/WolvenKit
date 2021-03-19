using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetRequiredDistanceCategory : animAnimNode_OnePoseInput
	{
		private CUInt32 _requiredQualityDistanceCategory;

		[Ordinal(12)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get => GetProperty(ref _requiredQualityDistanceCategory);
			set => SetProperty(ref _requiredQualityDistanceCategory, value);
		}

		public animAnimNode_SetRequiredDistanceCategory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
