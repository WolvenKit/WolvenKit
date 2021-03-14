using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInContextParams : CVariable
	{
		private CEnum<scnContextualActorName> _contextualName;
		private scnVoicetagId _voiceVagId;
		private CName _contextActorName;
		private TweakDBID _specRecordId;
		private CBool _forceMaxVisibility;

		[Ordinal(0)] 
		[RED("contextualName")] 
		public CEnum<scnContextualActorName> ContextualName
		{
			get
			{
				if (_contextualName == null)
				{
					_contextualName = (CEnum<scnContextualActorName>) CR2WTypeManager.Create("scnContextualActorName", "contextualName", cr2w, this);
				}
				return _contextualName;
			}
			set
			{
				if (_contextualName == value)
				{
					return;
				}
				_contextualName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voiceVagId")] 
		public scnVoicetagId VoiceVagId
		{
			get
			{
				if (_voiceVagId == null)
				{
					_voiceVagId = (scnVoicetagId) CR2WTypeManager.Create("scnVoicetagId", "voiceVagId", cr2w, this);
				}
				return _voiceVagId;
			}
			set
			{
				if (_voiceVagId == value)
				{
					return;
				}
				_voiceVagId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contextActorName")] 
		public CName ContextActorName
		{
			get
			{
				if (_contextActorName == null)
				{
					_contextActorName = (CName) CR2WTypeManager.Create("CName", "contextActorName", cr2w, this);
				}
				return _contextActorName;
			}
			set
			{
				if (_contextActorName == value)
				{
					return;
				}
				_contextActorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("specRecordId")] 
		public TweakDBID SpecRecordId
		{
			get
			{
				if (_specRecordId == null)
				{
					_specRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "specRecordId", cr2w, this);
				}
				return _specRecordId;
			}
			set
			{
				if (_specRecordId == value)
				{
					return;
				}
				_specRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get
			{
				if (_forceMaxVisibility == null)
				{
					_forceMaxVisibility = (CBool) CR2WTypeManager.Create("Bool", "forceMaxVisibility", cr2w, this);
				}
				return _forceMaxVisibility;
			}
			set
			{
				if (_forceMaxVisibility == value)
				{
					return;
				}
				_forceMaxVisibility = value;
				PropertySet(this);
			}
		}

		public scnFindEntityInContextParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
