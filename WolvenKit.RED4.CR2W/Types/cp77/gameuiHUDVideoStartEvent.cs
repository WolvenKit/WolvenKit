using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStartEvent : CVariable
	{
		private CUInt64 _videoPathHash;
		private CBool _playOnHud;
		private CBool _fullScreen;
		private Vector2 _position;
		private Vector2 _size;
		private CBool _skippable;
		private CBool _isLooped;
		private CBool _forceVideoFrameRate;

		[Ordinal(0)] 
		[RED("videoPathHash")] 
		public CUInt64 VideoPathHash
		{
			get
			{
				if (_videoPathHash == null)
				{
					_videoPathHash = (CUInt64) CR2WTypeManager.Create("Uint64", "videoPathHash", cr2w, this);
				}
				return _videoPathHash;
			}
			set
			{
				if (_videoPathHash == value)
				{
					return;
				}
				_videoPathHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playOnHud")] 
		public CBool PlayOnHud
		{
			get
			{
				if (_playOnHud == null)
				{
					_playOnHud = (CBool) CR2WTypeManager.Create("Bool", "playOnHud", cr2w, this);
				}
				return _playOnHud;
			}
			set
			{
				if (_playOnHud == value)
				{
					return;
				}
				_playOnHud = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fullScreen")] 
		public CBool FullScreen
		{
			get
			{
				if (_fullScreen == null)
				{
					_fullScreen = (CBool) CR2WTypeManager.Create("Bool", "fullScreen", cr2w, this);
				}
				return _fullScreen;
			}
			set
			{
				if (_fullScreen == value)
				{
					return;
				}
				_fullScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector2 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector2) CR2WTypeManager.Create("Vector2", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("size")] 
		public Vector2 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector2) CR2WTypeManager.Create("Vector2", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get
			{
				if (_skippable == null)
				{
					_skippable = (CBool) CR2WTypeManager.Create("Bool", "skippable", cr2w, this);
				}
				return _skippable;
			}
			set
			{
				if (_skippable == value)
				{
					return;
				}
				_skippable = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get
			{
				if (_isLooped == null)
				{
					_isLooped = (CBool) CR2WTypeManager.Create("Bool", "isLooped", cr2w, this);
				}
				return _isLooped;
			}
			set
			{
				if (_isLooped == value)
				{
					return;
				}
				_isLooped = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("forceVideoFrameRate")] 
		public CBool ForceVideoFrameRate
		{
			get
			{
				if (_forceVideoFrameRate == null)
				{
					_forceVideoFrameRate = (CBool) CR2WTypeManager.Create("Bool", "forceVideoFrameRate", cr2w, this);
				}
				return _forceVideoFrameRate;
			}
			set
			{
				if (_forceVideoFrameRate == value)
				{
					return;
				}
				_forceVideoFrameRate = value;
				PropertySet(this);
			}
		}

		public gameuiHUDVideoStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
