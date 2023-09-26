
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSmartGunHandlerParams_Record
	{
		[RED("blacklist")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Blacklist
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
