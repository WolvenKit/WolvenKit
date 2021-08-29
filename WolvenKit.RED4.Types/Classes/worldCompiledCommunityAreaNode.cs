using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCompiledCommunityAreaNode : worldNode
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
	}
}
