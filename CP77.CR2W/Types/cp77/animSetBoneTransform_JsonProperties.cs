using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSetBoneTransform_JsonProperties : ISerializable
	{
		[Ordinal(0)]  [RED("entries")] public CArray<animSetBoneTransform_JsonEntry> Entries { get; set; }

		public animSetBoneTransform_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
