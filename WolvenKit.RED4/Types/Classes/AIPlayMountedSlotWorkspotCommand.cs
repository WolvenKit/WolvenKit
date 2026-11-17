using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIPlayMountedSlotWorkspotCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("mountData")] 
		public gameMountDescriptor MountData
		{
			get => GetPropertyValue<gameMountDescriptor>();
			set => SetPropertyValue<gameMountDescriptor>(value);
		}

		public AIPlayMountedSlotWorkspotCommand()
		{
			MountData = new gameMountDescriptor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
