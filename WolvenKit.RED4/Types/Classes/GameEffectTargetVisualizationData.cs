using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameEffectTargetVisualizationData : IScriptable
	{
		[Ordinal(0)] 
		[RED("bucketName")] 
		public CName BucketName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("forceHighlightTargets")] 
		public CArray<entEntityID> ForceHighlightTargets
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public GameEffectTargetVisualizationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
