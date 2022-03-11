
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemBlueprintElement_Record
	{
		[RED("childElements")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ChildElements
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("prereqID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrereqID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("slot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Slot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
