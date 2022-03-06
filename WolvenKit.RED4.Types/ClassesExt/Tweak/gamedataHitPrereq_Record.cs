
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHitPrereq_Record
	{
		[RED("conditions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Conditions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
