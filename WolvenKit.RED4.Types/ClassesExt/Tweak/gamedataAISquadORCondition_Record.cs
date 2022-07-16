
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadORCondition_Record
	{
		[RED("OR")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OR
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
