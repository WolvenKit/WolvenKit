using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSceneRecordingContentObserverNode : worldNode
	{
		private worldSceneRecordingNodeFilter _filter;

		[Ordinal(4)] 
		[RED("filter")] 
		public worldSceneRecordingNodeFilter Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}

		public worldSceneRecordingContentObserverNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
