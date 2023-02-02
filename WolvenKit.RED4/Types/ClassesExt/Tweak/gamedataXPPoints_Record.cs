
namespace WolvenKit.RED4.Types
{
	public partial class gamedataXPPoints_Record
	{
		[RED("quantityModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> QuantityModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
