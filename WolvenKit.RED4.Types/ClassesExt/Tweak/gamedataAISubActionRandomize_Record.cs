
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionRandomize_Record
	{
		[RED("animVariationRandomize")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> AnimVariationRandomize
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
	}
}
