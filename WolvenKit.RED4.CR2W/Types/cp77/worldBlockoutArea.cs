using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutArea : ISerializable
	{
		private CString _name;
		private CColor _color;
		private CUInt32 _parent;
		private CArray<CUInt32> _children;
		private CArray<CHandle<worldBlockoutAreaOutline>> _outlines;
		private CBool _isFree;
		private CBool _increaseTerrainStreamingDistance;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(2)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CUInt32> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		[Ordinal(4)] 
		[RED("outlines")] 
		public CArray<CHandle<worldBlockoutAreaOutline>> Outlines
		{
			get => GetProperty(ref _outlines);
			set => SetProperty(ref _outlines, value);
		}

		[Ordinal(5)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get => GetProperty(ref _isFree);
			set => SetProperty(ref _isFree, value);
		}

		[Ordinal(6)] 
		[RED("increaseTerrainStreamingDistance")] 
		public CBool IncreaseTerrainStreamingDistance
		{
			get => GetProperty(ref _increaseTerrainStreamingDistance);
			set => SetProperty(ref _increaseTerrainStreamingDistance, value);
		}

		public worldBlockoutArea(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
