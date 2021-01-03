using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextConsumableParameters : CVariable
	{
		[Ordinal(0)]  [RED("CNameParameters")] public CStatic<128,gamestateMachineConsumableParameterCName> CNameParameters { get; set; }
		[Ordinal(1)]  [RED("IScriptableParameters")] public CStatic<128,gamestateMachineConsumableParameterIScriptable> IScriptableParameters { get; set; }
		[Ordinal(2)]  [RED("boolParameters")] public CStatic<128,gamestateMachineConsumableParameterBool> BoolParameters { get; set; }
		[Ordinal(3)]  [RED("doubleParameters")] public CStatic<128,gamestateMachineConsumableParameterDouble> DoubleParameters { get; set; }
		[Ordinal(4)]  [RED("floatParameters")] public CStatic<128,gamestateMachineConsumableParameterFloat> FloatParameters { get; set; }
		[Ordinal(5)]  [RED("intParameters")] public CStatic<128,gamestateMachineConsumableParameterInt> IntParameters { get; set; }
		[Ordinal(6)]  [RED("tweakDBIDParameters")] public CStatic<128,gamestateMachineConsumableParameterTweakDBID> TweakDBIDParameters { get; set; }
		[Ordinal(7)]  [RED("vectorParameters")] public CStatic<128,gamestateMachineConsumableParameterVector> VectorParameters { get; set; }
		[Ordinal(8)]  [RED("weakIScriptableParameters")] public CStatic<128,gamestateMachineConsumableParameterWeakIScriptable> WeakIScriptableParameters { get; set; }

		public gamestateMachineStateContextConsumableParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
