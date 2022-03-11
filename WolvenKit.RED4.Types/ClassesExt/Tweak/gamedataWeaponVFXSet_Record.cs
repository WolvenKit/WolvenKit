
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeaponVFXSet_Record
	{
		[RED("actions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Actions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
