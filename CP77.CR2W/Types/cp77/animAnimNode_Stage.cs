using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Stage : animAnimNode_Container
	{
		[Ordinal(0)]  [RED("inputPoses")] public CArray<animPoseLink> InputPoses { get; set; }

		public animAnimNode_Stage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
