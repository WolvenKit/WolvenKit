using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioConversationCharacterCondition : CVariable
	{
		private CName _voiceTag;
		private CUInt64 _characterRecordId;
		private CName _actorContextName;
		private CUInt64 _actorsInitialWorkspotNodeRefHash;

		[Ordinal(0)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get
			{
				if (_voiceTag == null)
				{
					_voiceTag = (CName) CR2WTypeManager.Create("CName", "voiceTag", cr2w, this);
				}
				return _voiceTag;
			}
			set
			{
				if (_voiceTag == value)
				{
					return;
				}
				_voiceTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("characterRecordId")] 
		public CUInt64 CharacterRecordId
		{
			get
			{
				if (_characterRecordId == null)
				{
					_characterRecordId = (CUInt64) CR2WTypeManager.Create("Uint64", "characterRecordId", cr2w, this);
				}
				return _characterRecordId;
			}
			set
			{
				if (_characterRecordId == value)
				{
					return;
				}
				_characterRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actorContextName")] 
		public CName ActorContextName
		{
			get
			{
				if (_actorContextName == null)
				{
					_actorContextName = (CName) CR2WTypeManager.Create("CName", "actorContextName", cr2w, this);
				}
				return _actorContextName;
			}
			set
			{
				if (_actorContextName == value)
				{
					return;
				}
				_actorContextName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("actorsInitialWorkspotNodeRefHash")] 
		public CUInt64 ActorsInitialWorkspotNodeRefHash
		{
			get
			{
				if (_actorsInitialWorkspotNodeRefHash == null)
				{
					_actorsInitialWorkspotNodeRefHash = (CUInt64) CR2WTypeManager.Create("Uint64", "actorsInitialWorkspotNodeRefHash", cr2w, this);
				}
				return _actorsInitialWorkspotNodeRefHash;
			}
			set
			{
				if (_actorsInitialWorkspotNodeRefHash == value)
				{
					return;
				}
				_actorsInitialWorkspotNodeRefHash = value;
				PropertySet(this);
			}
		}

		public audioConversationCharacterCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
