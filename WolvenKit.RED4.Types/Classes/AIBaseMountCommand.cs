using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIBaseMountCommand : AICommand
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
			Id = 4294967295;
		}
	}
}
