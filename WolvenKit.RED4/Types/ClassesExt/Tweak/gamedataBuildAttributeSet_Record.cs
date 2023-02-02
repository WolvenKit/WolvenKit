
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildAttributeSet_Record
	{
		[RED("attributes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Attributes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
