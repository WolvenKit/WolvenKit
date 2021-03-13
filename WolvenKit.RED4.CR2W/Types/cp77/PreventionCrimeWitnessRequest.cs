using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionCrimeWitnessRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("criminalPosition")] public Vector4 CriminalPosition { get; set; }

		public PreventionCrimeWitnessRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
