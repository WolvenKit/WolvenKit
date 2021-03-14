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
			get
			{
				if (_bending == null)
				{
					_bending = (garmentBendingParams) CR2WTypeManager.Create("garmentBendingParams", "bending", cr2w, this);
				}
				return _bending;
			}
			set
			{
				if (_bending == value)
				{
					return;
				}
				_bending = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("smoothing")] 
		public garmentSmoothingParams Smoothing
		{
			get
			{
				if (_smoothing == null)
				{
					_smoothing = (garmentSmoothingParams) CR2WTypeManager.Create("garmentSmoothingParams", "smoothing", cr2w, this);
				}
				return _smoothing;
			}
			set
			{
				if (_smoothing == value)
				{
					return;
				}
				_smoothing = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("collarArea")] 
		public garmentCollarAreaParams CollarArea
		{
			get
			{
				if (_collarArea == null)
				{
					_collarArea = (garmentCollarAreaParams) CR2WTypeManager.Create("garmentCollarAreaParams", "collarArea", cr2w, this);
				}
				return _collarArea;
			}
			set
			{
				if (_collarArea == value)
				{
					return;
				}
				_collarArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hiddenTrianglesRemoval")] 
		public garmentHiddenTrianglesRemovalParams HiddenTrianglesRemoval
		{
			get
			{
				if (_hiddenTrianglesRemoval == null)
				{
					_hiddenTrianglesRemoval = (garmentHiddenTrianglesRemovalParams) CR2WTypeManager.Create("garmentHiddenTrianglesRemovalParams", "hiddenTrianglesRemoval", cr2w, this);
				}
				return _hiddenTrianglesRemoval;
			}
			set
			{
				if (_hiddenTrianglesRemoval == value)
				{
					return;
				}
				_hiddenTrianglesRemoval = value;
				PropertySet(this);
			}
		}

		public garmentGarmentLayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
