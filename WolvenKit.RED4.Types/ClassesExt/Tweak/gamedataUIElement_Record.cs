
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUIElement_Record
	{
		[RED("customConditions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CustomConditions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
