using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCommunityAreaNode : worldNode
	{
		private CHandle<communityArea> _area;
		private entEntityID _sourceObjectId;

		[Ordinal(4)] 
		[RED("area")] 
		public CHandle<communityArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(5)] 
		[RED("sourceObjectId")] 
		public entEntityID SourceObjectId
		{
			get => GetProperty(ref _sourceObjectId);
			set => SetProperty(ref _sourceObjectId, value);
		}

		public worldCompiledCommunityAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
