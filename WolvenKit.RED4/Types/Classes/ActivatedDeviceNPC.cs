using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceNPC : ActivatedDeviceTransfromAnim
	{
		[Ordinal(99)] 
		[RED("hasProperAnimations")] 
		public CBool HasProperAnimations
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ActivatedDeviceNPC()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
