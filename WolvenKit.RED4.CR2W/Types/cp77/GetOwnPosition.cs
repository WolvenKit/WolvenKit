using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetOwnPosition : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("outPosition")] public CHandle<AIArgumentMapping> OutPosition { get; set; }

		public GetOwnPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
