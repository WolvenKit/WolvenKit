using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questQuestPrefabsEntry : RedBaseClass
	{
		private worldGlobalNodeRef _nodeRef;
		private CEnum<worldQuestPrefabLoadingMode> _loadingMode;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public worldGlobalNodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(1)] 
		[RED("loadingMode")] 
		public CEnum<worldQuestPrefabLoadingMode> LoadingMode
		{
			get => GetProperty(ref _loadingMode);
			set => SetProperty(ref _loadingMode, value);
		}
	}
}
