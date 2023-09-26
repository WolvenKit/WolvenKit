
namespace WolvenKit.RED4.Types
{
	public partial class gamedataModifyAttackCritChanceEffector_Record
	{
		[RED("critChance")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CritChance
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
