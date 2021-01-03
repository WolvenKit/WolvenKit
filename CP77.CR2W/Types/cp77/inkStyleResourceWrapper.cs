using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStyleResourceWrapper : ISerializable
	{
		[Ordinal(0)]  [RED("styleResource")] public raRef<inkStyleResource> StyleResource { get; set; }

		public inkStyleResourceWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
