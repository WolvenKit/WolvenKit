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
			get
			{
				if (_width == null)
				{
					_width = (CUInt16) CR2WTypeManager.Create("Uint16", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt16 Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CUInt16) CR2WTypeManager.Create("Uint16", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt16 Depth
		{
			get
			{
				if (_depth == null)
				{
					_depth = (CUInt16) CR2WTypeManager.Create("Uint16", "depth", cr2w, this);
				}
				return _depth;
			}
			set
			{
				if (_depth == value)
				{
					return;
				}
				_depth = value;
				PropertySet(this);
			}
		}

		public rendRenderTextureBlobSizeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
