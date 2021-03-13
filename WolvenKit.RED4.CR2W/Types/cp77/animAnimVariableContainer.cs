using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableContainer : ISerializable
	{
		[Ordinal(0)] [RED("boolVariables")] public CArray<CHandle<animAnimVariableBool>> BoolVariables { get; set; }
		[Ordinal(1)] [RED("intVariables")] public CArray<CHandle<animAnimVariableInt>> IntVariables { get; set; }
		[Ordinal(2)] [RED("floatVariables")] public CArray<CHandle<animAnimVariableFloat>> FloatVariables { get; set; }
		[Ordinal(3)] [RED("vectorVariables")] public CArray<CHandle<animAnimVariableVector>> VectorVariables { get; set; }
		[Ordinal(4)] [RED("quaternionVariables")] public CArray<CHandle<animAnimVariableQuaternion>> QuaternionVariables { get; set; }
		[Ordinal(5)] [RED("transformVariables")] public CArray<CHandle<animAnimVariableTransform>> TransformVariables { get; set; }

		public animAnimVariableContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
