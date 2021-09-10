using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneScreen : gameObject
	{
		[Ordinal(40)] 
		[RED("uiAnimationsData")] 
		public CHandle<SceneScreenUIAnimationsData> UiAnimationsData
		{
			get => GetPropertyValue<CHandle<SceneScreenUIAnimationsData>>();
			set => SetPropertyValue<CHandle<SceneScreenUIAnimationsData>>(value);
		}

		[Ordinal(41)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CHandle<gameIBlackboard>>();
			set => SetPropertyValue<CHandle<gameIBlackboard>>(value);
		}
	}
}
