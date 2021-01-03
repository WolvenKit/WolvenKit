using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animOverrideAnimSetRef : CVariable
	{
		[Ordinal(0)]  [RED("animSet")] public raRef<animAnimSet> AnimSet { get; set; }
		[Ordinal(1)]  [RED("variableName")] public CName VariableName { get; set; }

		public animOverrideAnimSetRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
