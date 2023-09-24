
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankLevelSpawnableArrangement_Record
	{
		[RED("arrangementList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ArrangementList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
