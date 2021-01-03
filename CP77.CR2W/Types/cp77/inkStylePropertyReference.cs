using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStylePropertyReference : CVariable
	{
		[Ordinal(0)]  [RED("referencedPath")] public CName ReferencedPath { get; set; }

		public inkStylePropertyReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
