using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectAnimationDatabase : ISerializable
	{
		[Ordinal(0)] [RED("animationData")] public CArray<gameAnimationExtractedData> AnimationData { get; set; }
		[Ordinal(1)] [RED("bodyTypesData")] public CArray<gameBodyTypeData> BodyTypesData { get; set; }

		public gameSmartObjectAnimationDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
