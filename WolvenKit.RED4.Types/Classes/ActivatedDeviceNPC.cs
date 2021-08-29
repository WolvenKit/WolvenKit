using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivatedDeviceNPC : ActivatedDeviceTransfromAnim
	{
		private CBool _hasProperAnimations;

		[Ordinal(98)] 
		[RED("hasProperAnimations")] 
		public CBool HasProperAnimations
		{
			get => GetProperty(ref _hasProperAnimations);
			set => SetProperty(ref _hasProperAnimations, value);
		}
	}
}
