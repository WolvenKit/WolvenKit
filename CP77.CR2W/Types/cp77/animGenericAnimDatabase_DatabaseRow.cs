using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase_DatabaseRow : CVariable
	{
		[Ordinal(0)]  [RED("animationData")] public animGenericAnimDatabase_AnimationData AnimationData { get; set; }
		[Ordinal(1)]  [RED("inputValues")] public CArray<CInt32> InputValues { get; set; }

		public animGenericAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
