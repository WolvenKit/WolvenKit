
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionOR_Record
	{
		[RED("OR")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OR
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
