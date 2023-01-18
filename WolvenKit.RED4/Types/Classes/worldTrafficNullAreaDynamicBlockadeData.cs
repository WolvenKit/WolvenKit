using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficNullAreaDynamicBlockadeData : ISerializable
	{
		[Ordinal(0)] 
		[RED("nullAreasBlockades")] 
		public CArray<worldTrafficNullAreaDynamicBlockade> NullAreasBlockades
		{
			get => GetPropertyValue<CArray<worldTrafficNullAreaDynamicBlockade>>();
			set => SetPropertyValue<CArray<worldTrafficNullAreaDynamicBlockade>>(value);
		}

		public worldTrafficNullAreaDynamicBlockadeData()
		{
			NullAreasBlockades = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
