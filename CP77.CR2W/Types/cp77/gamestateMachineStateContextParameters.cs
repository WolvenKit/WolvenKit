using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextParameters : CVariable
	{
		[Ordinal(0)]  [RED("CNameParameters")] public CStatic<128,gamestateMachineActionParameterCName> CNameParameters { get; set; }
		[Ordinal(1)]  [RED("IScriptableParameters")] public CStatic<128,gamestateMachineActionParameterIScriptable> IScriptableParameters { get; set; }
		[Ordinal(2)]  [RED("boolParameters")] public CStatic<128,gamestateMachineActionParameterBool> BoolParameters { get; set; }
		[Ordinal(3)]  [RED("doubleParameters")] public CStatic<128,gamestateMachineActionParameterDouble> DoubleParameters { get; set; }
		[Ordinal(4)]  [RED("floatParameters")] public CStatic<128,gamestateMachineActionParameterFloat> FloatParameters { get; set; }
		[Ordinal(5)]  [RED("intParameters")] public CStatic<128,gamestateMachineActionParameterInt> IntParameters { get; set; }
		[Ordinal(6)]  [RED("tweakDBIDParameters")] public CStatic<128,gamestateMachineActionParameterTweakDBID> TweakDBIDParameters { get; set; }
		[Ordinal(7)]  [RED("vectorParameters")] public CStatic<128,gamestateMachineActionParameterVector> VectorParameters { get; set; }

		public gamestateMachineStateContextParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
