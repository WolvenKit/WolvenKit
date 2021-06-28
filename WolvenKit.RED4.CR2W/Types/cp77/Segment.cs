using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Segment : CVariable
	{
		private Vector4 _origin;
		private Vector4 _direction;

		[Ordinal(0)] 
		[RED("origin")] 
		public Vector4 Origin
		{
			get => GetProperty(ref _origin);
			set => SetProperty(ref _origin, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public Segment(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
