using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DistrictManager : IScriptable
	{
		[Ordinal(0)]  [RED("stack")] public CArray<CHandle<District>> Stack { get; set; }
		[Ordinal(1)]  [RED("system")] public wCHandle<PreventionSystem> System { get; set; }
		[Ordinal(2)]  [RED("visitedDistricts")] public CArray<TweakDBID> VisitedDistricts { get; set; }

		public DistrictManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
