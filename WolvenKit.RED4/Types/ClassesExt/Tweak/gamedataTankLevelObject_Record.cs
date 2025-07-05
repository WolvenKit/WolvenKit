
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankLevelObject_Record
	{
		[RED("objectList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObjectList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
