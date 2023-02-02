using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldBlockoutPoint : ISerializable
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<CUInt32> Edges
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("constraint")] 
		public CInt32 Constraint
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldBlockoutPoint()
		{
			Position = new();
			Edges = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
