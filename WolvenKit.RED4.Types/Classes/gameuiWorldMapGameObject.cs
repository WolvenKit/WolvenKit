using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiWorldMapGameObject : gameObject
	{
		[Ordinal(40)] 
		[RED("districts")] 
		public CArray<gameuiDistrictTriggerData> Districts
		{
			get => GetPropertyValue<CArray<gameuiDistrictTriggerData>>();
			set => SetPropertyValue<CArray<gameuiDistrictTriggerData>>(value);
		}

		public gameuiWorldMapGameObject()
		{
			Districts = new();
		}
	}
}
