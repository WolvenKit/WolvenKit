using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProcessVisualTags : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ProcessVisualTags()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
