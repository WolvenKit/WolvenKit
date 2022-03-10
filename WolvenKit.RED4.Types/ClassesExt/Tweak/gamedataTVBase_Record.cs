
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTVBase_Record
	{
		[RED("channels")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Channels
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
