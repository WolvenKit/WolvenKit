using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDrive : CVariable
	{
		private CFloat _forceLimit;
		private CBool _isAcceleration;
		private CFloat _stiffness;
		private CFloat _damping;

		[Ordinal(0)] 
		[RED("forceLimit")] 
		public CFloat ForceLimit
		{
			get => GetProperty(ref _forceLimit);
			set => SetProperty(ref _forceLimit, value);
		}

		[Ordinal(1)] 
		[RED("isAcceleration")] 
		public CBool IsAcceleration
		{
			get => GetProperty(ref _isAcceleration);
			set => SetProperty(ref _isAcceleration, value);
		}

		[Ordinal(2)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get => GetProperty(ref _stiffness);
			set => SetProperty(ref _stiffness, value);
		}

		[Ordinal(3)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetProperty(ref _damping);
			set => SetProperty(ref _damping, value);
		}

		public physicsPhysicsJointDrive(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
