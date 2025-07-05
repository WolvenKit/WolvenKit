
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadDistanceRelationToSectorCheck_Record
	{
		[RED("sectors")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Sectors
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
