using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMountedObjectInfo : ISerializable
	{
		private CBool _isFirst;
		private CBool _isPlayer;
		private gameEntityReference _ref;
		private CBool _onMount;
		private CEnum<gameMountingSlotRole> _role;

		[Ordinal(0)] 
		[RED("isFirst")] 
		public CBool IsFirst
		{
			get => GetProperty(ref _isFirst);
			set => SetProperty(ref _isFirst, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("ref")] 
		public gameEntityReference Ref
		{
			get => GetProperty(ref _ref);
			set => SetProperty(ref _ref, value);
		}

		[Ordinal(3)] 
		[RED("onMount")] 
		public CBool OnMount
		{
			get => GetProperty(ref _onMount);
			set => SetProperty(ref _onMount, value);
		}

		[Ordinal(4)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}
	}
}
