using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitConePair : physicsPhysicsJointLimitBase
	{
		private CEnum<physicsPhysicsJointMotion> _swingY;
		private CEnum<physicsPhysicsJointMotion> _swingZ;
		private CFloat _yAngle;
		private CFloat _zAngle;

		[Ordinal(5)] 
		[RED("swingY")] 
		public CEnum<physicsPhysicsJointMotion> SwingY
		{
			get => GetProperty(ref _swingY);
			set => SetProperty(ref _swingY, value);
		}

		[Ordinal(6)] 
		[RED("swingZ")] 
		public CEnum<physicsPhysicsJointMotion> SwingZ
		{
			get => GetProperty(ref _swingZ);
			set => SetProperty(ref _swingZ, value);
		}

		[Ordinal(7)] 
		[RED("yAngle")] 
		public CFloat YAngle
		{
			get => GetProperty(ref _yAngle);
			set => SetProperty(ref _yAngle, value);
		}

		[Ordinal(8)] 
		[RED("zAngle")] 
		public CFloat ZAngle
		{
			get => GetProperty(ref _zAngle);
			set => SetProperty(ref _zAngle, value);
		}

		public physicsPhysicsJointLimitConePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
