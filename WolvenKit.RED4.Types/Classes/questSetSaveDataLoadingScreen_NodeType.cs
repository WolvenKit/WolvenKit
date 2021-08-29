using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetSaveDataLoadingScreen_NodeType : questIUIManagerNodeType
	{
		private TweakDBID _selectedLoading;

		[Ordinal(0)] 
		[RED("selectedLoading")] 
		public TweakDBID SelectedLoading
		{
			get => GetProperty(ref _selectedLoading);
			set => SetProperty(ref _selectedLoading, value);
		}
	}
}
