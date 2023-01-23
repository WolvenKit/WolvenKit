
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNetworkPresetBinderParameters_Record
	{
		[RED("pingPresetID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PingPresetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
