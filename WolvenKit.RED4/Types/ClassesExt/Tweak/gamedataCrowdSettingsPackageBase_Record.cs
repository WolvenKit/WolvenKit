
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCrowdSettingsPackageBase_Record
	{
		[RED("specs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Specs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
