
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemQueryElement_Record
	{
		[RED("query")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Query
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
