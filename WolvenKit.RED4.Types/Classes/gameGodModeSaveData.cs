using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGodModeSaveData : ISerializable
	{
		[Ordinal(0)] 
		[RED("gods")] 
		public CArray<gameGodModeSaveEntityData> Gods
		{
			get => GetPropertyValue<CArray<gameGodModeSaveEntityData>>();
			set => SetPropertyValue<CArray<gameGodModeSaveEntityData>>(value);
		}

		public gameGodModeSaveData()
		{
			Gods = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
