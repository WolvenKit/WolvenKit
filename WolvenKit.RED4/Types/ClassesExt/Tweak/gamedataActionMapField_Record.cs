
namespace WolvenKit.RED4.Types
{
	public partial class gamedataActionMapField_Record
	{
		[RED("itemType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("map")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Map
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
