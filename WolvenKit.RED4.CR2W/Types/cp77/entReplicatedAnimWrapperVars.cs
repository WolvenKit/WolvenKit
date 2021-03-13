using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedAnimWrapperVars : CVariable
	{
		[Ordinal(0)] [RED("serverReplicatedTime")] public netTime ServerReplicatedTime { get; set; }
		[Ordinal(1)] [RED("data")] public CArray<entReplicatedVariableValue> Data { get; set; }

		public entReplicatedAnimWrapperVars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
