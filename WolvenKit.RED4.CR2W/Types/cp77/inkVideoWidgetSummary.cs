using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoWidgetSummary : CVariable
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CUInt32 _currentTimeMs;
		private CUInt32 _totalTimeMs;
		private CUInt32 _currentFrame;
		private CUInt32 _totalFrames;
		private CUInt32 _frameRate;

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
		[RED("currentTimeMs")] 
		public CUInt32 CurrentTimeMs
		{
			get
			{
				if (_currentTimeMs == null)
				{
					_currentTimeMs = (CUInt32) CR2WTypeManager.Create("Uint32", "currentTimeMs", cr2w, this);
				}
				return _currentTimeMs;
			}
			set
			{
				if (_currentTimeMs == value)
				{
					return;
				}
				_currentTimeMs = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("totalTimeMs")] 
		public CUInt32 TotalTimeMs
		{
			get
			{
				if (_totalTimeMs == null)
				{
					_totalTimeMs = (CUInt32) CR2WTypeManager.Create("Uint32", "totalTimeMs", cr2w, this);
				}
				return _totalTimeMs;
			}
			set
			{
				if (_totalTimeMs == value)
				{
					return;
				}
				_totalTimeMs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentFrame")] 
		public CUInt32 CurrentFrame
		{
			get
			{
				if (_currentFrame == null)
				{
					_currentFrame = (CUInt32) CR2WTypeManager.Create("Uint32", "currentFrame", cr2w, this);
				}
				return _currentFrame;
			}
			set
			{
				if (_currentFrame == value)
				{
					return;
				}
				_currentFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("totalFrames")] 
		public CUInt32 TotalFrames
		{
			get
			{
				if (_totalFrames == null)
				{
					_totalFrames = (CUInt32) CR2WTypeManager.Create("Uint32", "totalFrames", cr2w, this);
				}
				return _totalFrames;
			}
			set
			{
				if (_totalFrames == value)
				{
					return;
				}
				_totalFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("frameRate")] 
		public CUInt32 FrameRate
		{
			get
			{
				if (_frameRate == null)
				{
					_frameRate = (CUInt32) CR2WTypeManager.Create("Uint32", "frameRate", cr2w, this);
				}
				return _frameRate;
			}
			set
			{
				if (_frameRate == value)
				{
					return;
				}
				_frameRate = value;
				PropertySet(this);
			}
		}

		public inkVideoWidgetSummary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
