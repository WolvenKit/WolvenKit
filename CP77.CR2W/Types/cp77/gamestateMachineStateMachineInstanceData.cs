using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineInstanceData : CVariable
	{
		[Ordinal(0)]  [RED("initData")] public CHandle<IScriptable> InitData { get; set; }
		[Ordinal(1)]  [RED("priority")] public CUInt32 Priority { get; set; }
		[Ordinal(2)]  [RED("referenceName")] public CName ReferenceName { get; set; }

		public gamestateMachineStateMachineInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
