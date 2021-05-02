using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsColliderCapsule : physicsICollider
	{
		private CFloat _radius;
		private CFloat _height;

		[Ordinal(8)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(9)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		public physicsColliderCapsule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
