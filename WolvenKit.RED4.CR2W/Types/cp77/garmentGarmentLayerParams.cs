using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentGarmentLayerParams : CResource
	{
		private garmentBendingParams _bending;
		private garmentSmoothingParams _smoothing;
		private garmentCollarAreaParams _collarArea;
		private garmentHiddenTrianglesRemovalParams _hiddenTrianglesRemoval;

		[Ordinal(1)] 
		[RED("bending")] 
		public garmentBendingParams Bending
		{
			get => GetProperty(ref _bending);
			set => SetProperty(ref _bending, value);
		}

		[Ordinal(2)] 
		[RED("smoothing")] 
		public garmentSmoothingParams Smoothing
		{
			get => GetProperty(ref _smoothing);
			set => SetProperty(ref _smoothing, value);
		}

		[Ordinal(3)] 
		[RED("collarArea")] 
		public garmentCollarAreaParams CollarArea
		{
			get => GetProperty(ref _collarArea);
			set => SetProperty(ref _collarArea, value);
		}

		[Ordinal(4)] 
		[RED("hiddenTrianglesRemoval")] 
		public garmentHiddenTrianglesRemovalParams HiddenTrianglesRemoval
		{
			get => GetProperty(ref _hiddenTrianglesRemoval);
			set => SetProperty(ref _hiddenTrianglesRemoval, value);
		}

		public garmentGarmentLayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
