using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables_Class : IScriptable
	{
		[Ordinal(0)]  [RED("thisIsReplicatedFieldInClass")] public CInt32 ThisIsReplicatedFieldInClass { get; set; }

		public Ref_6_ReplicatedVariables_Class(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
