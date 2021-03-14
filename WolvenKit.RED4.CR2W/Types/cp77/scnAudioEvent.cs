using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAudioEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CName _audioEventName;
		private CName _ambientUniqueName;
		private CName _emitterName;
		private CEnum<scnAudioFastForwardSupport> _fastForwardSupport;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get
			{
				if (_audioEventName == null)
				{
					_audioEventName = (CName) CR2WTypeManager.Create("CName", "audioEventName", cr2w, this);
				}
				return _audioEventName;
			}
			set
			{
				if (_audioEventName == value)
				{
					return;
				}
				_audioEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ambientUniqueName")] 
		public CName AmbientUniqueName
		{
			get
			{
				if (_ambientUniqueName == null)
				{
					_ambientUniqueName = (CName) CR2WTypeManager.Create("CName", "ambientUniqueName", cr2w, this);
				}
				return _ambientUniqueName;
			}
			set
			{
				if (_ambientUniqueName == value)
				{
					return;
				}
				_ambientUniqueName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get
			{
				if (_emitterName == null)
				{
					_emitterName = (CName) CR2WTypeManager.Create("CName", "emitterName", cr2w, this);
				}
				return _emitterName;
			}
			set
			{
				if (_emitterName == value)
				{
					return;
				}
				_emitterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("fastForwardSupport")] 
		public CEnum<scnAudioFastForwardSupport> FastForwardSupport
		{
			get
			{
				if (_fastForwardSupport == null)
				{
					_fastForwardSupport = (CEnum<scnAudioFastForwardSupport>) CR2WTypeManager.Create("scnAudioFastForwardSupport", "fastForwardSupport", cr2w, this);
				}
				return _fastForwardSupport;
			}
			set
			{
				if (_fastForwardSupport == value)
				{
					return;
				}
				_fastForwardSupport = value;
				PropertySet(this);
			}
		}

		public scnAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
