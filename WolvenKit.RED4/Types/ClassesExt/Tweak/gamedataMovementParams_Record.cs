
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMovementParams_Record
	{
		[RED("params")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Params
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
