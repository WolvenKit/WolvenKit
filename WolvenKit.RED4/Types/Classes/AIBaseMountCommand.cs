using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AIBaseMountCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get => GetPropertyValue<CHandle<gameMountEventData>>();
			set => SetPropertyValue<CHandle<gameMountEventData>>(value);
		}

		public AIBaseMountCommand()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
