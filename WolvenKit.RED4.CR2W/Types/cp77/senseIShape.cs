using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseIShape : IScriptable
	{
		[Ordinal(0)] [RED("id")] public TweakDBID Id { get; set; }

		public senseIShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
