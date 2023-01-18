
namespace WolvenKit.RED4.Types
{
	public partial class gamedataActionMap_Record
	{
		[RED("defaultMap")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefaultMap
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("map")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Map
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
