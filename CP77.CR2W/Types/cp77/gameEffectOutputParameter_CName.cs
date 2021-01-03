using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectOutputParameter_CName : CVariable
	{
		[Ordinal(0)]  [RED("blackboardProperty")] public gameBlackboardPropertyBindingDefinition BlackboardProperty { get; set; }

		public gameEffectOutputParameter_CName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
