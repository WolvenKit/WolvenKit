using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingContentObserverNode : worldNode
	{
		[Ordinal(0)]  [RED("filter")] public worldSceneRecordingNodeFilter Filter { get; set; }

		public worldSceneRecordingContentObserverNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
