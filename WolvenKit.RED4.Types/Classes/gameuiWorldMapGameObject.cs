using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWorldMapGameObject : gameObject
	{
		private CArray<gameuiDistrictTriggerData> _districts;

		[Ordinal(40)] 
		[RED("districts")] 
		public CArray<gameuiDistrictTriggerData> Districts
		{
			get => GetProperty(ref _districts);
			set => SetProperty(ref _districts, value);
		}
	}
}
