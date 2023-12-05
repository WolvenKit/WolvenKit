
namespace WolvenKit.RED4.Types
{
	public partial class gamedatadevice_scanning_data_Record
	{
		[RED("iconScale")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> IconScale
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
