using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExpressionSocket : ISerializable
	{
		[Ordinal(0)] [RED("typeHint")] public AIbehaviorTypeRef TypeHint { get; set; }
		[Ordinal(1)] [RED("expression")] public CHandle<AIbehaviorPassiveExpressionDefinition> Expression { get; set; }

		public AIbehaviorExpressionSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
