using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CSourceTexture : ISerializable
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CUInt32 _depth;
		private CUInt32 _pitch;
		private CEnum<ETextureRawFormat> _format;

		[Ordinal(0)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CUInt32) CR2WTypeManager.Create("Uint32", "width", cr2w, this);
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
		public CUInt32 Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CUInt32) CR2WTypeManager.Create("Uint32", "height", cr2w, this);
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
		public CUInt32 Depth
		{
			get
			{
				if (_depth == null)
				{
					_depth = (CUInt32) CR2WTypeManager.Create("Uint32", "depth", cr2w, this);
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

		[Ordinal(3)] 
		[RED("pitch")] 
		public CUInt32 Pitch
		{
			get
			{
				if (_pitch == null)
				{
					_pitch = (CUInt32) CR2WTypeManager.Create("Uint32", "pitch", cr2w, this);
				}
				return _pitch;
			}
			set
			{
				if (_pitch == value)
				{
					return;
				}
				_pitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("format")] 
		public CEnum<ETextureRawFormat> Format
		{
			get
			{
				if (_format == null)
				{
					_format = (CEnum<ETextureRawFormat>) CR2WTypeManager.Create("ETextureRawFormat", "format", cr2w, this);
				}
				return _format;
			}
			set
			{
				if (_format == value)
				{
					return;
				}
				_format = value;
				PropertySet(this);
			}
		}

		public CSourceTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
