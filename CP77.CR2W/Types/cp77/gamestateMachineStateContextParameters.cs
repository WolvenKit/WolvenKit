using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateContextParameters : CVariable
	{
		[Ordinal(0)]  [RED("CNameParameters", 128)] public CStatic<gamestateMachineActionParameterCName> CNameParameters { get; set; }
		[Ordinal(1)]  [RED("IScriptableParameters", 128)] public CStatic<gamestateMachineActionParameterIScriptable> IScriptableParameters { get; set; }
		[Ordinal(2)]  [RED("boolParameters", 128)] public CStatic<gamestateMachineActionParameterBool> BoolParameters { get; set; }
		[Ordinal(3)]  [RED("doubleParameters", 128)] public CStatic<gamestateMachineActionParameterDouble> DoubleParameters { get; set; }
		[Ordinal(4)]  [RED("floatParameters", 128)] public CStatic<gamestateMachineActionParameterFloat> FloatParameters { get; set; }
		[Ordinal(5)]  [RED("intParameters", 128)] public CStatic<gamestateMachineActionParameterInt> IntParameters { get; set; }
		[Ordinal(6)]  [RED("tweakDBIDParameters", 128)] public CStatic<gamestateMachineActionParameterTweakDBID> TweakDBIDParameters { get; set; }
		[Ordinal(7)]  [RED("vectorParameters", 128)] public CStatic<gamestateMachineActionParameterVector> VectorParameters { get; set; }

		public gamestateMachineStateContextParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
