using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficNullAreaDynamicBlockadeData : ISerializable
	{
		private CArray<worldTrafficNullAreaDynamicBlockade> _nullAreasBlockades;

		[Ordinal(0)] 
		[RED("nullAreasBlockades")] 
		public CArray<worldTrafficNullAreaDynamicBlockade> NullAreasBlockades
		{
			get => GetProperty(ref _nullAreasBlockades);
			set => SetProperty(ref _nullAreasBlockades, value);
		}
	}
}
