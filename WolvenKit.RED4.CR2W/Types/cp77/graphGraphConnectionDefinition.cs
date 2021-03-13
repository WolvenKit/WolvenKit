using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class graphGraphConnectionDefinition : graphIGraphObjectDefinition
	{
		[Ordinal(0)] [RED("source")] public wCHandle<graphGraphSocketDefinition> Source { get; set; }
		[Ordinal(1)] [RED("destination")] public wCHandle<graphGraphSocketDefinition> Destination { get; set; }

		public graphGraphConnectionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
