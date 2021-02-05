using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextConsumableParameters : CVariable
	{
		[Ordinal(0)]  [RED("boolParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterBoo, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterBool> BoolParameters { get; set; }
		[Ordinal(1)]  [RED("intParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterIn, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterInt> IntParameters { get; set; }
		[Ordinal(2)]  [RED("floatParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterFloa, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterFloat> FloatParameters { get; set; }
		[Ordinal(3)]  [RED("doubleParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterDoubl, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterDouble> DoubleParameters { get; set; }
		[Ordinal(4)]  [RED("vectorParameters", lignas(16) StaticArray<gamestateMachineConsumableParameterVecto, 128)] public alignas(16) StaticArray<gamestateMachineConsumableParameterVector> VectorParameters { get; set; }
		[Ordinal(5)]  [RED("CNameParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterCNam, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterCName> CNameParameters { get; set; }
		[Ordinal(6)]  [RED("IScriptableParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterIScriptabl, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterIScriptable> IScriptableParameters { get; set; }
		[Ordinal(7)]  [RED("weakIScriptableParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterWeakIScriptabl, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterWeakIScriptable> WeakIScriptableParameters { get; set; }
		[Ordinal(8)]  [RED("tweakDBIDParameters", lignas(8) StaticArray<gamestateMachineConsumableParameterTweakDBI, 128)] public alignas(8) StaticArray<gamestateMachineConsumableParameterTweakDBID> TweakDBIDParameters { get; set; }

		public gamestateMachineStateContextConsumableParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
