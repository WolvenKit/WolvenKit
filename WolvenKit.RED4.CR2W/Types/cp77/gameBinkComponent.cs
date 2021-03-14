using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBinkComponent : entIVisualComponent
	{
		private CHandle<gameBinkMeshTargetBinding> _meshTargetBinding;
		private CName _videoPlayerName;
		private raRef<Bink> _binkResource;
		private CName _audioEvent;
		private CBool _loopVideo;
		private CBool _forceVideoFrameRate;
		private CBool _isEnabled;

		[Ordinal(8)] 
		[RED("meshTargetBinding")] 
		public CHandle<gameBinkMeshTargetBinding> MeshTargetBinding
		{
			get
			{
				if (_meshTargetBinding == null)
				{
					_meshTargetBinding = (CHandle<gameBinkMeshTargetBinding>) CR2WTypeManager.Create("handle:gameBinkMeshTargetBinding", "meshTargetBinding", cr2w, this);
				}
				return _meshTargetBinding;
			}
			set
			{
				if (_meshTargetBinding == value)
				{
					return;
				}
				_meshTargetBinding = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("videoPlayerName")] 
		public CName VideoPlayerName
		{
			get
			{
				if (_videoPlayerName == null)
				{
					_videoPlayerName = (CName) CR2WTypeManager.Create("CName", "videoPlayerName", cr2w, this);
				}
				return _videoPlayerName;
			}
			set
			{
				if (_videoPlayerName == value)
				{
					return;
				}
				_videoPlayerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("binkResource")] 
		public raRef<Bink> BinkResource
		{
			get
			{
				if (_binkResource == null)
				{
					_binkResource = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "binkResource", cr2w, this);
				}
				return _binkResource;
			}
			set
			{
				if (_binkResource == value)
				{
					return;
				}
				_binkResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get
			{
				if (_audioEvent == null)
				{
					_audioEvent = (CName) CR2WTypeManager.Create("CName", "audioEvent", cr2w, this);
				}
				return _audioEvent;
			}
			set
			{
				if (_audioEvent == value)
				{
					return;
				}
				_audioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("loopVideo")] 
		public CBool LoopVideo
		{
			get
			{
				if (_loopVideo == null)
				{
					_loopVideo = (CBool) CR2WTypeManager.Create("Bool", "loopVideo", cr2w, this);
				}
				return _loopVideo;
			}
			set
			{
				if (_loopVideo == value)
				{
					return;
				}
				_loopVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public gameBinkComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
