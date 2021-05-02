using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobSizeInfo : CVariable
	{
		private CUInt16 _width;
		private CUInt16 _height;
		private CUInt16 _depth;

		[Ordinal(0)] 
		[RED("width")] 
		public CUInt16 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt16 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt16 Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}

		public rendRenderTextureBlobSizeInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
