using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OrientedBox : RedBaseClass
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
	}
}
