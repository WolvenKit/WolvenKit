
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadSpatialForOwnTarget_Record
	{
		[RED("spatial")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Spatial
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
