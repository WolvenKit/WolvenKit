using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SSFXOperationData : CVariable
	{
		[Ordinal(0)]  [RED("operationType")] public CEnum<EEffectOperationType> OperationType { get; set; }
		[Ordinal(1)]  [RED("sfxName")] public CName SfxName { get; set; }

		public SSFXOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
