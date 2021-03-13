using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneVariableReadActionData : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("comparer")] public CEnum<audioNumberComparer> Comparer { get; set; }
		[Ordinal(2)] [RED("value")] public CInt32 Value { get; set; }

		public audioAudioSceneVariableReadActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
