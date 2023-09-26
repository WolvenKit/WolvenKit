using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_DEV_ScriptableSystemUseNewTooltips : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UI_DEV_ScriptableSystemUseNewTooltips()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
