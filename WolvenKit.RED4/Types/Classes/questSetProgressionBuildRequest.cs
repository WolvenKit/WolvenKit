using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetProgressionBuildRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("buildID")] 
		public TweakDBID BuildID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questSetProgressionBuildRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
