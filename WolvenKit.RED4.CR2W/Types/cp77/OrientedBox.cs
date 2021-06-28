using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OrientedBox : CVariable
	{
		private Vector4 _position;
		private Vector4 _edge_1;
		private Vector4 _edge_2;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("edge 1")] 
		public Vector4 Edge_1
		{
			get => GetProperty(ref _edge_1);
			set => SetProperty(ref _edge_1, value);
		}

		[Ordinal(2)] 
		[RED("edge 2")] 
		public Vector4 Edge_2
		{
			get => GetProperty(ref _edge_2);
			set => SetProperty(ref _edge_2, value);
		}

		public OrientedBox(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
