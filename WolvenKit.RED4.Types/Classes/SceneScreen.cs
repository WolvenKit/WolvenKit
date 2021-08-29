using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneScreen : gameObject
	{
		private CHandle<SceneScreenUIAnimationsData> _uiAnimationsData;
		private CHandle<gameIBlackboard> _blackboard;

		[Ordinal(40)] 
		[RED("uiAnimationsData")] 
		public CHandle<SceneScreenUIAnimationsData> UiAnimationsData
		{
			get => GetProperty(ref _uiAnimationsData);
			set => SetProperty(ref _uiAnimationsData, value);
		}

		[Ordinal(41)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}
	}
}
