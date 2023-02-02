
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildCyberware_Record
	{
		[RED("cyberware")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Cyberware
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
