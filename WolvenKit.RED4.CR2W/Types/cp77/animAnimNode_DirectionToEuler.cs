using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectionToEuler : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("inputNode")] public animVectorLink InputNode { get; set; }
		[Ordinal(12)] [RED("initialForwardVector")] public Vector4 InitialForwardVector { get; set; }
		[Ordinal(13)] [RED("conversionType")] public CEnum<animEDirectionToEuler> ConversionType { get; set; }

		public animAnimNode_DirectionToEuler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
