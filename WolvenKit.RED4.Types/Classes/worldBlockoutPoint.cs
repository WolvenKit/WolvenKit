using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBlockoutPoint : ISerializable
	{
		private Vector2 _position;
		private CArray<CUInt32> _edges;
		private CInt32 _constraint;
		private CBool _isFree;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<CUInt32> Edges
		{
			get => GetProperty(ref _edges);
			set => SetProperty(ref _edges, value);
		}

		[Ordinal(2)] 
		[RED("constraint")] 
		public CInt32 Constraint
		{
			get => GetProperty(ref _constraint);
			set => SetProperty(ref _constraint, value);
		}

		[Ordinal(3)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetProperty(ref _isFree);
			set => SetProperty(ref _isFree, value);
		}
	}
}
