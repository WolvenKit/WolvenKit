using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobMemoryLayout : CVariable
	{
		private CUInt32 _rowPitch;
		private CUInt32 _slicePitch;

		[Ordinal(0)] 
		[RED("rowPitch")] 
		public CUInt32 RowPitch
		{
			get => GetProperty(ref _rowPitch);
			set => SetProperty(ref _rowPitch, value);
		}

		[Ordinal(1)] 
		[RED("slicePitch")] 
		public CUInt32 SlicePitch
		{
			get => GetProperty(ref _slicePitch);
			set => SetProperty(ref _slicePitch, value);
		}

		public rendRenderTextureBlobMemoryLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
