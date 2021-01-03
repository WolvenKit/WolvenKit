using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TogglePreventionSystem : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(1)]  [RED("sourceName")] public CName SourceName { get; set; }

		public TogglePreventionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
