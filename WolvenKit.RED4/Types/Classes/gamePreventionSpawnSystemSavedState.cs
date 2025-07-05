using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePreventionSpawnSystemSavedState : ISerializable
	{
		[Ordinal(0)] 
		[RED("areaIds")] 
		public CArray<CUInt64> AreaIds
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		public gamePreventionSpawnSystemSavedState()
		{
			AreaIds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
