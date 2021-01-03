using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkanimDefinition : IScriptable
	{
		[Ordinal(0)]  [RED("events")] public CArray<CHandle<inkanimEvent>> Events { get; set; }
		[Ordinal(1)]  [RED("interpolators")] public CArray<CHandle<inkanimInterpolator>> Interpolators { get; set; }

		public inkanimDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
