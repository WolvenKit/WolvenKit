using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeParametersForwarder : CVariable
	{
		[Ordinal(0)]  [RED("overrides")] public CArray<CUInt32> Overrides { get; set; }

		public LibTreeParametersForwarder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
