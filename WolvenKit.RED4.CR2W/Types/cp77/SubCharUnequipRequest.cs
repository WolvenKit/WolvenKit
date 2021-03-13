using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubCharUnequipRequest : UnequipRequest
	{
		[Ordinal(3)] [RED("subCharType")] public CEnum<gamedataSubCharacter> SubCharType { get; set; }

		public SubCharUnequipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
