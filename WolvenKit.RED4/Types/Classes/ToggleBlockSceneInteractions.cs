using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleBlockSceneInteractions : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("block")] 
		public CBool Block
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleBlockSceneInteractions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
