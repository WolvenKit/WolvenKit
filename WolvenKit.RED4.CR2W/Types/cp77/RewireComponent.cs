using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RewireComponent : gameScriptableComponent
	{
		private redResourceReferenceScriptToken _miniGameVideoPath;
		private CName _miniGameAudioEvent;
		private CFloat _miniGameVideoLenght;
		private CHandle<RewireEvent> _rewireEvent;
		private CFloat _rewireCurrentLenght;
		private CBool _isActive;

		[Ordinal(5)] 
		[RED("miniGameVideoPath")] 
		public redResourceReferenceScriptToken MiniGameVideoPath
		{
			get
			{
				if (_miniGameVideoPath == null)
				{
					_miniGameVideoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "miniGameVideoPath", cr2w, this);
				}
				return _miniGameVideoPath;
			}
			set
			{
				if (_miniGameVideoPath == value)
				{
					return;
				}
				_miniGameVideoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("miniGameAudioEvent")] 
		public CName MiniGameAudioEvent
		{
			get
			{
				if (_miniGameAudioEvent == null)
				{
					_miniGameAudioEvent = (CName) CR2WTypeManager.Create("CName", "miniGameAudioEvent", cr2w, this);
				}
				return _miniGameAudioEvent;
			}
			set
			{
				if (_miniGameAudioEvent == value)
				{
					return;
				}
				_miniGameAudioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("miniGameVideoLenght")] 
		public CFloat MiniGameVideoLenght
		{
			get
			{
				if (_miniGameVideoLenght == null)
				{
					_miniGameVideoLenght = (CFloat) CR2WTypeManager.Create("Float", "miniGameVideoLenght", cr2w, this);
				}
				return _miniGameVideoLenght;
			}
			set
			{
				if (_miniGameVideoLenght == value)
				{
					return;
				}
				_miniGameVideoLenght = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rewireEvent")] 
		public CHandle<RewireEvent> RewireEvent
		{
			get
			{
				if (_rewireEvent == null)
				{
					_rewireEvent = (CHandle<RewireEvent>) CR2WTypeManager.Create("handle:RewireEvent", "rewireEvent", cr2w, this);
				}
				return _rewireEvent;
			}
			set
			{
				if (_rewireEvent == value)
				{
					return;
				}
				_rewireEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rewireCurrentLenght")] 
		public CFloat RewireCurrentLenght
		{
			get
			{
				if (_rewireCurrentLenght == null)
				{
					_rewireCurrentLenght = (CFloat) CR2WTypeManager.Create("Float", "rewireCurrentLenght", cr2w, this);
				}
				return _rewireCurrentLenght;
			}
			set
			{
				if (_rewireCurrentLenght == value)
				{
					return;
				}
				_rewireCurrentLenght = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public RewireComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
