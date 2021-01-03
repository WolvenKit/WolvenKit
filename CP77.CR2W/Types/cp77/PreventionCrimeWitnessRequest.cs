using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PreventionCrimeWitnessRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("criminalPosition")] public Vector4 CriminalPosition { get; set; }

		public PreventionCrimeWitnessRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
