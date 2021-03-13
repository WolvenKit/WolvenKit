using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSequence : IScriptable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("definitions")] public CArray<CHandle<inkanimDefinition>> Definitions { get; set; }
		[Ordinal(2)] [RED("targets")] public CArray<CHandle<inkanimSequenceTargetInfo>> Targets { get; set; }

		public inkanimSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
