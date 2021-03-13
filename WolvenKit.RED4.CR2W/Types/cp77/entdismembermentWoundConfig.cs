using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentWoundConfig : ISerializable
	{
		[Ordinal(0)] [RED("WoundName")] public CName WoundName { get; set; }
		[Ordinal(1)] [RED("ResourceSet")] public CEnum<entdismembermentResourceSetE> ResourceSet { get; set; }

		public entdismembermentWoundConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
