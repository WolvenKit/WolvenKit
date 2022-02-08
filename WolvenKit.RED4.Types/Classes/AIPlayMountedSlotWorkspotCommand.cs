using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			MountData = new() { ParentId = new(), InitialTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } }, MountType = Enums.gameMountDescriptorMountType.KeepState };
		}
	}
}
