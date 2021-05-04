using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSimpleCone : senseIShape
	{
		private Vector4 _position1;
		private Vector4 _position2;
		private CFloat _radius1;
		private CFloat _radius2;

		[Ordinal(1)] 
		[RED("position1")] 
		public Vector4 Position1
		{
			get => GetProperty(ref _position1);
			set => SetProperty(ref _position1, value);
		}

		[Ordinal(2)] 
		[RED("position2")] 
		public Vector4 Position2
		{
			get => GetProperty(ref _position2);
			set => SetProperty(ref _position2, value);
		}

		[Ordinal(3)] 
		[RED("radius1")] 
		public CFloat Radius1
		{
			get => GetProperty(ref _radius1);
			set => SetProperty(ref _radius1, value);
		}

		[Ordinal(4)] 
		[RED("radius2")] 
		public CFloat Radius2
		{
			get => GetProperty(ref _radius2);
			set => SetProperty(ref _radius2, value);
		}

		public senseSimpleCone(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
