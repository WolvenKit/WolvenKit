using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProtectedEntities : MorphData
	{
		[Ordinal(1)] [RED("protectedEntities")] public CArray<entEntityID> ProtectedEntities_ { get; set; }

		public ProtectedEntities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
