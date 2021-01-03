using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SVFXOperationData : CVariable
	{
		[Ordinal(0)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(1)]  [RED("operationType")] public CEnum<EEffectOperationType> OperationType { get; set; }
		[Ordinal(2)]  [RED("shouldPersist")] public CBool ShouldPersist { get; set; }
		[Ordinal(3)]  [RED("size")] public CFloat Size { get; set; }
		[Ordinal(4)]  [RED("vfxName")] public CName VfxName { get; set; }
		[Ordinal(5)]  [RED("vfxResource")] public gameFxResource VfxResource { get; set; }

		public SVFXOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
