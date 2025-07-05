
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatPoolCost_Record
	{
		[RED("statPool")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatPool
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
