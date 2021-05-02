using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TagLinkedCluekRequest : gameScriptableSystemRequest
	{
		private CBool _tag;
		private LinkedFocusClueData _linkedCluekData;

		[Ordinal(0)] 
		[RED("tag")] 
		public CBool Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("linkedCluekData")] 
		public LinkedFocusClueData LinkedCluekData
		{
			get => GetProperty(ref _linkedCluekData);
			set => SetProperty(ref _linkedCluekData, value);
		}

		public TagLinkedCluekRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
