using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextParameters : CVariable
	{
		[Ordinal(0)]  [RED("boolParameters", lignas(8) StaticArray<gamestateMachineActionParameterBoo, 128)] public alignas(8) StaticArray<gamestateMachineActionParameterBool> BoolParameters { get; set; }
		[Ordinal(1)]  [RED("intParameters", lignas(8) StaticArray<gamestateMachineActionParameterIn, 128)] public alignas(8) StaticArray<gamestateMachineActionParameterInt> IntParameters { get; set; }
		[Ordinal(2)]  [RED("floatParameters", lignas(8) StaticArray<gamestateMachineActionParameterFloa, 128)] public alignas(8) StaticArray<gamestateMachineActionParameterFloat> FloatParameters { get; set; }
		[Ordinal(3)]  [RED("doubleParameters", lignas(8) StaticArray<gamestateMachineActionParameterDoubl, 128)] public alignas(8) StaticArray<gamestateMachineActionParameterDouble> DoubleParameters { get; set; }
		[Ordinal(4)]  [RED("vectorParameters", lignas(16) StaticArray<gamestateMachineActionParameterVecto, 128)] public alignas(16) StaticArray<gamestateMachineActionParameterVector> VectorParameters { get; set; }
		[Ordinal(5)]  [RED("CNameParameters", lignas(8) StaticArray<gamestateMachineActionParameterCNam, 128)] public alignas(8) StaticArray<gamestateMachineActionParameterCName> CNameParameters { get; set; }
		[Ordinal(6)]  [RED("IScriptableParameters", lignas(8) StaticArray<gamestateMachineActionParameterIScriptabl, 128)] public alignas(8) StaticArray<gamestateMachineActionParameterIScriptable> IScriptableParameters { get; set; }
		[Ordinal(7)]  [RED("tweakDBIDParameters", lignas(8) StaticArray<gamestateMachineActionParameterTweakDBI, 128)] public alignas(8) StaticArray<gamestateMachineActionParameterTweakDBID> TweakDBIDParameters { get; set; }

		public gamestateMachineStateContextParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
