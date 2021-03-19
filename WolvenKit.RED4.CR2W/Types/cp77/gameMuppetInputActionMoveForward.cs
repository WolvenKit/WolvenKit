using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionMoveForward : gameIMuppetInputAction
	{
		private Vector2 _direction;
		private CBool _isSprinting;

		[Ordinal(0)] 
		[RED("direction")] 
		public Vector2 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(1)] 
		[RED("isSprinting")] 
		public CBool IsSprinting
		{
			get => GetProperty(ref _isSprinting);
			set => SetProperty(ref _isSprinting, value);
		}

		public gameMuppetInputActionMoveForward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
