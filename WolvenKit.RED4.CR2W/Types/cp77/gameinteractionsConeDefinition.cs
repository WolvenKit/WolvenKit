using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsConeDefinition : gameinteractionsIShapeDefinition
	{
		private Vector4 _pos1;
		private Vector4 _pos2;
		private CFloat _radius1;
		private CFloat _radius2;

		[Ordinal(0)] 
		[RED("pos1")] 
		public Vector4 Pos1
		{
			get => GetProperty(ref _pos1);
			set => SetProperty(ref _pos1, value);
		}

		[Ordinal(1)] 
		[RED("pos2")] 
		public Vector4 Pos2
		{
			get => GetProperty(ref _pos2);
			set => SetProperty(ref _pos2, value);
		}

		[Ordinal(2)] 
		[RED("radius1")] 
		public CFloat Radius1
		{
			get => GetProperty(ref _radius1);
			set => SetProperty(ref _radius1, value);
		}

		[Ordinal(3)] 
		[RED("radius2")] 
		public CFloat Radius2
		{
			get => GetProperty(ref _radius2);
			set => SetProperty(ref _radius2, value);
		}

		public gameinteractionsConeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
