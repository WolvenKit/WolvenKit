using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointAngularLimitPair : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _twist;
		private CFloat _upper;
		private CFloat _lower;

		[Ordinal(5)] 
		[RED("twist")] 
		public CEnum<physicsPhysicsJointMotion> Twist
		{
			get => GetProperty(ref _twist);
			set => SetProperty(ref _twist, value);
		}

		[Ordinal(6)] 
		[RED("upper")] 
		public CFloat Upper
		{
			get => GetProperty(ref _upper);
			set => SetProperty(ref _upper, value);
		}

		[Ordinal(7)] 
		[RED("lower")] 
		public CFloat Lower
		{
			get => GetProperty(ref _lower);
			set => SetProperty(ref _lower, value);
		}

		public physicsPhysicsJointAngularLimitPair(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
