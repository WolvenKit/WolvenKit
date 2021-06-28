using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpTestPlatformController : gameObject
	{
		private NodeRef _platform;
		private NodeRef _pointA;
		private NodeRef _pointB;
		private CFloat _speed;

		[Ordinal(40)] 
		[RED("platform")] 
		public NodeRef Platform
		{
			get => GetProperty(ref _platform);
			set => SetProperty(ref _platform, value);
		}

		[Ordinal(41)] 
		[RED("pointA")] 
		public NodeRef PointA
		{
			get => GetProperty(ref _pointA);
			set => SetProperty(ref _pointA, value);
		}

		[Ordinal(42)] 
		[RED("pointB")] 
		public NodeRef PointB
		{
			get => GetProperty(ref _pointB);
			set => SetProperty(ref _pointB, value);
		}

		[Ordinal(43)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		public cpTestPlatformController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
