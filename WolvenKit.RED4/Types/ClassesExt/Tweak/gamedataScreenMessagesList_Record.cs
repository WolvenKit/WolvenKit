
namespace WolvenKit.RED4.Types
{
	public partial class gamedataScreenMessagesList_Record
	{
		[RED("messages")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Messages
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
