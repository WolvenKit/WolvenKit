using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LibTreeParameterList : CVariable
	{
		[Ordinal(0)]  [RED("parameters")] public CArray<LibTreeParameter> Parameters { get; set; }

		public LibTreeParameterList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
