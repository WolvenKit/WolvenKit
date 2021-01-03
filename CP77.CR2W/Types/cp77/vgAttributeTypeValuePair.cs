using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vgAttributeTypeValuePair : ISerializable
	{
		[Ordinal(0)]  [RED("lue")] public CVariant Lue { get; set; }
		[Ordinal(1)]  [RED("pe")] public CEnum<vgEStyleAttributeType> Pe { get; set; }

		public vgAttributeTypeValuePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
