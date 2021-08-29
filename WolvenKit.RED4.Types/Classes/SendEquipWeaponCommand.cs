using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SendEquipWeaponCommand : AIbehaviortaskScript
	{
		private CBool _secondary;

		[Ordinal(0)] 
		[RED("secondary")] 
		public CBool Secondary
		{
			get => GetProperty(ref _secondary);
			set => SetProperty(ref _secondary, value);
		}
	}
}
