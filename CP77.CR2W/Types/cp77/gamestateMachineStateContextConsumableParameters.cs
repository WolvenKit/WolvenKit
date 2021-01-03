using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextConsumableParameters : CVariable
	{
		[Ordinal(0)]  [RED("CNameParameters", 128)] public CStatic<gamestateMachineConsumableParameterCName> CNameParameters { get; set; }
		[Ordinal(1)]  [RED("IScriptableParameters", 128)] public CStatic<gamestateMachineConsumableParameterIScriptable> IScriptableParameters { get; set; }
		[Ordinal(2)]  [RED("boolParameters", 128)] public CStatic<gamestateMachineConsumableParameterBool> BoolParameters { get; set; }
		[Ordinal(3)]  [RED("doubleParameters", 128)] public CStatic<gamestateMachineConsumableParameterDouble> DoubleParameters { get; set; }
		[Ordinal(4)]  [RED("floatParameters", 128)] public CStatic<gamestateMachineConsumableParameterFloat> FloatParameters { get; set; }
		[Ordinal(5)]  [RED("intParameters", 128)] public CStatic<gamestateMachineConsumableParameterInt> IntParameters { get; set; }
		[Ordinal(6)]  [RED("tweakDBIDParameters", 128)] public CStatic<gamestateMachineConsumableParameterTweakDBID> TweakDBIDParameters { get; set; }
		[Ordinal(7)]  [RED("vectorParameters", 128)] public CStatic<gamestateMachineConsumableParameterVector> VectorParameters { get; set; }
		[Ordinal(8)]  [RED("weakIScriptableParameters", 128)] public CStatic<gamestateMachineConsumableParameterWeakIScriptable> WeakIScriptableParameters { get; set; }

		public gamestateMachineStateContextConsumableParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
