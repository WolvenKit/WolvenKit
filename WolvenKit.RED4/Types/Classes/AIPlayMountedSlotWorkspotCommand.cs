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
			MountData = new gameMountDescriptor { ParentId = new entEntityID(), InitialTransform = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } }, MountType = Enums.gameMountDescriptorMountType.KeepState };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
