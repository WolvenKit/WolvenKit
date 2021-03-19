using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiContraPlayer : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		private CFloat _mass;
		private CFloat _jumpForce;
		private CFloat _movementSpeed;

		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(2)] 
		[RED("jumpForce")] 
		public CFloat JumpForce
		{
			get => GetProperty(ref _jumpForce);
			set => SetProperty(ref _jumpForce, value);
		}

		[Ordinal(3)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get => GetProperty(ref _movementSpeed);
			set => SetProperty(ref _movementSpeed, value);
		}

		public gameuiContraPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
