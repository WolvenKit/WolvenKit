
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemObjectToCheck_Record
	{
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
