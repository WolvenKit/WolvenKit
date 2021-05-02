using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Quad : CVariable
	{
		private Vector4 _p1;
		private Vector4 _p2;
		private Vector4 _p3;
		private Vector4 _p4;

		[Ordinal(0)] 
		[RED("p1")] 
		public Vector4 P1
		{
			get => GetProperty(ref _p1);
			set => SetProperty(ref _p1, value);
		}

		[Ordinal(1)] 
		[RED("p2")] 
		public Vector4 P2
		{
			get => GetProperty(ref _p2);
			set => SetProperty(ref _p2, value);
		}

		[Ordinal(2)] 
		[RED("p3")] 
		public Vector4 P3
		{
			get => GetProperty(ref _p3);
			set => SetProperty(ref _p3, value);
		}

		[Ordinal(3)] 
		[RED("p4")] 
		public Vector4 P4
		{
			get => GetProperty(ref _p4);
			set => SetProperty(ref _p4, value);
		}

		public Quad(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
