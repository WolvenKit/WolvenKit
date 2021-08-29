using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerUnauthorized : ActionBool
	{
		private CBool _isLiftDoor;

		[Ordinal(25)] 
		[RED("isLiftDoor")] 
		public CBool IsLiftDoor
		{
			get => GetProperty(ref _isLiftDoor);
			set => SetProperty(ref _isLiftDoor, value);
		}
	}
}
