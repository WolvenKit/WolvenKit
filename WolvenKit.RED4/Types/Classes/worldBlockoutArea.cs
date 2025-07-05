using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldBlockoutArea : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CUInt32> Children
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(4)] 
		[RED("outlines")] 
		public CArray<CHandle<worldBlockoutAreaOutline>> Outlines
		{
			get => GetPropertyValue<CArray<CHandle<worldBlockoutAreaOutline>>>();
			set => SetPropertyValue<CArray<CHandle<worldBlockoutAreaOutline>>>(value);
		}

		[Ordinal(5)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("increaseTerrainStreamingDistance")] 
		public CBool IncreaseTerrainStreamingDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldBlockoutArea()
		{
			Color = new CColor();
			Parent = uint.MaxValue;
			Children = new();
			Outlines = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
