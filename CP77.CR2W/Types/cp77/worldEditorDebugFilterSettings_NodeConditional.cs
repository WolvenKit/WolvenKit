using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldEditorDebugFilterSettings_NodeConditional : worldEditorDebugFilterSettings
	{
		[Ordinal(0)]  [RED("isDiscarded")] public CBool IsDiscarded { get; set; }
		[Ordinal(1)]  [RED("isProxyDependencyModeAutoSet")] public CBool IsProxyDependencyModeAutoSet { get; set; }
		[Ordinal(2)]  [RED("isProxyDependencyModeDiscardedSet")] public CBool IsProxyDependencyModeDiscardedSet { get; set; }

		public worldEditorDebugFilterSettings_NodeConditional(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
