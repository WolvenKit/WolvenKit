
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLCDScreen_Record
	{
		[RED("message")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Message
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
