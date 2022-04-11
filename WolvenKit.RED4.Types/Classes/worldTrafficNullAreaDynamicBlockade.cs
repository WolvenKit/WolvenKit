using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficNullAreaDynamicBlockade : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaID")] 
		public CUInt64 AreaID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("offmeshLinks")] 
		public CArray<CUInt64> OffmeshLinks
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(2)] 
		[RED("affectedTrafficLanes")] 
		public CArray<worldTrafficLaneUID> AffectedTrafficLanes
		{
			get => GetPropertyValue<CArray<worldTrafficLaneUID>>();
			set => SetPropertyValue<CArray<worldTrafficLaneUID>>(value);
		}

		public worldTrafficNullAreaDynamicBlockade()
		{
			OffmeshLinks = new();
			AffectedTrafficLanes = new();
		}
	}
}
