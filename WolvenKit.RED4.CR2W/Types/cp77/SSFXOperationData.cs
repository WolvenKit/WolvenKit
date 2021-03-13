using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSFXOperationData : CVariable
	{
		[Ordinal(0)] [RED("sfxName")] public CName SfxName { get; set; }
		[Ordinal(1)] [RED("operationType")] public CEnum<EEffectOperationType> OperationType { get; set; }

		public SSFXOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
