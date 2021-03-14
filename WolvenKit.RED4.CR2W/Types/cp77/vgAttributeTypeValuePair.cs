using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgAttributeTypeValuePair : ISerializable
	{
		[Ordinal(0)] [RED("pe")] public CEnum<vgEStyleAttributeType> Pe { get; set; }
		[Ordinal(1)] [RED("lue")] public CVariant Lue { get; set; }

		public vgAttributeTypeValuePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
