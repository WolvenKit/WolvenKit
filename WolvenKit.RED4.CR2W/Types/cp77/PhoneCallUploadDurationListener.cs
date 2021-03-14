using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneCallUploadDurationListener : gameCustomValueStatPoolsListener
	{
		private ScriptGameInstance _gameInstance;
		private wCHandle<ScriptedPuppet> _requesterPuppet;
		private entEntityID _requesterID;
		private CFloat _duration;
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requesterPuppet")] 
		public wCHandle<ScriptedPuppet> RequesterPuppet
		{
			get
			{
				if (_requesterPuppet == null)
				{
					_requesterPuppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "requesterPuppet", cr2w, this);
				}
				return _requesterPuppet;
			}
			set
			{
				if (_requesterPuppet == value)
				{
					return;
				}
				_requesterPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get
			{
				if (_requesterID == null)
				{
					_requesterID = (entEntityID) CR2WTypeManager.Create("entEntityID", "requesterID", cr2w, this);
				}
				return _requesterID;
			}
			set
			{
				if (_requesterID == value)
				{
					return;
				}
				_requesterID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		public PhoneCallUploadDurationListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
