using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entReplicatedAnimWrapperVars : CVariable
	{
		[Ordinal(0)]  [RED("data")] public CArray<entReplicatedVariableValue> Data { get; set; }
		[Ordinal(1)]  [RED("serverReplicatedTime")] public netTime ServerReplicatedTime { get; set; }

		public entReplicatedAnimWrapperVars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
