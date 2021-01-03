using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectionToEuler : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("conversionType")] public CEnum<animEDirectionToEuler> ConversionType { get; set; }
		[Ordinal(1)]  [RED("initialForwardVector")] public Vector4 InitialForwardVector { get; set; }
		[Ordinal(2)]  [RED("inputNode")] public animVectorLink InputNode { get; set; }

		public animAnimNode_DirectionToEuler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
