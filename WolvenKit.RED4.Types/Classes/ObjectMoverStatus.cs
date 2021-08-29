using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ObjectMoverStatus : redEvent
	{
		private CName _ownerName;
		private CEnum<EMovementDirection> _direction;

		[Ordinal(0)] 
		[RED("ownerName")] 
		public CName OwnerName
		{
			get => GetProperty(ref _ownerName);
			set => SetProperty(ref _ownerName, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<EMovementDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}
	}
}
