using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SecurityTurretData : animAnimFeature
	{
		private CBool _shoot;
		private CBool _isRippedOff;
		private CBool _ripOffSide;
		private CBool _isOverriden;

		[Ordinal(0)] 
		[RED("Shoot")] 
		public CBool Shoot
		{
			get => GetProperty(ref _shoot);
			set => SetProperty(ref _shoot, value);
		}

		[Ordinal(1)] 
		[RED("isRippedOff")] 
		public CBool IsRippedOff
		{
			get => GetProperty(ref _isRippedOff);
			set => SetProperty(ref _isRippedOff, value);
		}

		[Ordinal(2)] 
		[RED("ripOffSide")] 
		public CBool RipOffSide
		{
			get => GetProperty(ref _ripOffSide);
			set => SetProperty(ref _ripOffSide, value);
		}

		[Ordinal(3)] 
		[RED("isOverriden")] 
		public CBool IsOverriden
		{
			get => GetProperty(ref _isOverriden);
			set => SetProperty(ref _isOverriden, value);
		}

		public AnimFeature_SecurityTurretData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
