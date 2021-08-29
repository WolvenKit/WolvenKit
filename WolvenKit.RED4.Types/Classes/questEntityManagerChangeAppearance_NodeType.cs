using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityManagerChangeAppearance_NodeType : questIEntityManager_NodeType
	{
		private gameEntityReference _entityRef;
		private CBool _prefetchOnly;
		private CName _appearanceName;

		[Ordinal(0)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		[Ordinal(1)] 
		[RED("prefetchOnly")] 
		public CBool PrefetchOnly
		{
			get => GetProperty(ref _prefetchOnly);
			set => SetProperty(ref _prefetchOnly, value);
		}

		[Ordinal(2)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}
	}
}
