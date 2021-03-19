using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLinearLimit : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _x;
		private CEnum<physicsPhysicsJointMotion> _y;
		private CEnum<physicsPhysicsJointMotion> _z;
		private CFloat _value;

		[Ordinal(5)] 
		[RED("x")] 
		public CEnum<physicsPhysicsJointMotion> X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(6)] 
		[RED("y")] 
		public CEnum<physicsPhysicsJointMotion> Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(7)] 
		[RED("z")] 
		public CEnum<physicsPhysicsJointMotion> Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		[Ordinal(8)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public physicsPhysicsJointLinearLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
