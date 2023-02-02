
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCurves_Record
	{
		[RED("curves")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Curves
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
