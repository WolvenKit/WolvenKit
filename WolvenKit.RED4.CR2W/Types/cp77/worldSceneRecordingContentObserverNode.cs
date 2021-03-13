using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingContentObserverNode : worldNode
	{
		[Ordinal(4)] [RED("filter")] public worldSceneRecordingNodeFilter Filter { get; set; }

		public worldSceneRecordingContentObserverNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
