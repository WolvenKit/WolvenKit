using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetProgressionBuildRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("buildID")] 
		public TweakDBID BuildID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameSetProgressionBuildRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
