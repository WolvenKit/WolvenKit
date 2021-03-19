using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_IndustrialArm : animAnimFeature
	{
		private CInt32 _idleAnimNumber;
		private CBool _isRotate;
		private CBool _isDistraction;
		private CBool _isPoke;

		[Ordinal(0)] 
		[RED("idleAnimNumber")] 
		public CInt32 IdleAnimNumber
		{
			get => GetProperty(ref _idleAnimNumber);
			set => SetProperty(ref _idleAnimNumber, value);
		}

		[Ordinal(1)] 
		[RED("isRotate")] 
		public CBool IsRotate
		{
			get => GetProperty(ref _isRotate);
			set => SetProperty(ref _isRotate, value);
		}

		[Ordinal(2)] 
		[RED("isDistraction")] 
		public CBool IsDistraction
		{
			get => GetProperty(ref _isDistraction);
			set => SetProperty(ref _isDistraction, value);
		}

		[Ordinal(3)] 
		[RED("isPoke")] 
		public CBool IsPoke
		{
			get => GetProperty(ref _isPoke);
			set => SetProperty(ref _isPoke, value);
		}

		public AnimFeature_IndustrialArm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
