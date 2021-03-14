using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		[Ordinal(1)] [RED("listenConstantly")] public CBool ListenConstantly { get; set; }

		public ConstantStatPoolPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
