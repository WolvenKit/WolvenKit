
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyStatusEffectByChanceEffector_Record
	{
		[RED("effectorChance")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EffectorChance
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
