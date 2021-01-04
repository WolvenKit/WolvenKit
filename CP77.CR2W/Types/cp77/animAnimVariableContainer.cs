using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableContainer : ISerializable
	{
		[Ordinal(0)]  [RED("boolVariables")] public CArray<CHandle<animAnimVariableBool>> BoolVariables { get; set; }
		[Ordinal(1)]  [RED("floatVariables")] public CArray<CHandle<animAnimVariableFloat>> FloatVariables { get; set; }
		[Ordinal(2)]  [RED("intVariables")] public CArray<CHandle<animAnimVariableInt>> IntVariables { get; set; }
		[Ordinal(3)]  [RED("quaternionVariables")] public CArray<CHandle<animAnimVariableQuaternion>> QuaternionVariables { get; set; }
		[Ordinal(4)]  [RED("transformVariables")] public CArray<CHandle<animAnimVariableTransform>> TransformVariables { get; set; }
		[Ordinal(5)]  [RED("vectorVariables")] public CArray<CHandle<animAnimVariableVector>> VectorVariables { get; set; }

		public animAnimVariableContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
