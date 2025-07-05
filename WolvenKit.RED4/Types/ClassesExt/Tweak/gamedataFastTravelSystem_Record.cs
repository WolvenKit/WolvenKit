
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFastTravelSystem_Record
	{
		[RED("fastTravelPointsTotal")]
		[REDProperty(IsIgnored = true)]
		public CInt32 FastTravelPointsTotal
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
