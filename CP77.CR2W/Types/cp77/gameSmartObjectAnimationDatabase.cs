using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectAnimationDatabase : ISerializable
	{
		[Ordinal(0)]  [RED("animationData")] public CArray<gameAnimationExtractedData> AnimationData { get; set; }
		[Ordinal(1)]  [RED("bodyTypesData")] public CArray<gameBodyTypeData> BodyTypesData { get; set; }

		public gameSmartObjectAnimationDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
