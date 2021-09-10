using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceNPC : ActivatedDeviceTransfromAnim
	{
		[Ordinal(98)] 
		[RED("hasProperAnimations")] 
		public CBool HasProperAnimations
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ActivatedDeviceNPC()
		{
			ControllerTypeName = "ActivatedDeviceNPCController";
		}
	}
}
