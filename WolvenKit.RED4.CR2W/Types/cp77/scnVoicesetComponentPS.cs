using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnVoicesetComponentPS : gameComponentPS
	{
		private CArray<entVoicesetInputToBlock> _blockedInputs;
		private CName _voiceTag;
		private CEnum<gamedataNPCHighLevelState> _nPCHighLevelState;
		private CUInt32 _gruntSetIndex;
		private CBool _areVoicesetLinesEnabled;
		private CBool _areVoicesetGruntsEnabled;

		[Ordinal(0)] 
		[RED("blockedInputs")] 
		public CArray<entVoicesetInputToBlock> BlockedInputs
		{
			get
			{
				if (_blockedInputs == null)
				{
					_blockedInputs = (CArray<entVoicesetInputToBlock>) CR2WTypeManager.Create("array:entVoicesetInputToBlock", "blockedInputs", cr2w, this);
				}
				return _blockedInputs;
			}
			set
			{
				if (_blockedInputs == value)
				{
					return;
				}
				_blockedInputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("NPCHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> NPCHighLevelState
		{
			get
			{
				if (_nPCHighLevelState == null)
				{
					_nPCHighLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "NPCHighLevelState", cr2w, this);
				}
				return _nPCHighLevelState;
			}
			set
			{
				if (_nPCHighLevelState == value)
				{
					return;
				}
				_nPCHighLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gruntSetIndex")] 
		public CUInt32 GruntSetIndex
		{
			get
			{
				if (_gruntSetIndex == null)
				{
					_gruntSetIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "gruntSetIndex", cr2w, this);
				}
				return _gruntSetIndex;
			}
			set
			{
				if (_gruntSetIndex == value)
				{
					return;
				}
				_gruntSetIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("areVoicesetLinesEnabled")] 
		public CBool AreVoicesetLinesEnabled
		{
			get
			{
				if (_areVoicesetLinesEnabled == null)
				{
					_areVoicesetLinesEnabled = (CBool) CR2WTypeManager.Create("Bool", "areVoicesetLinesEnabled", cr2w, this);
				}
				return _areVoicesetLinesEnabled;
			}
			set
			{
				if (_areVoicesetLinesEnabled == value)
				{
					return;
				}
				_areVoicesetLinesEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("areVoicesetGruntsEnabled")] 
		public CBool AreVoicesetGruntsEnabled
		{
			get
			{
				if (_areVoicesetGruntsEnabled == null)
				{
					_areVoicesetGruntsEnabled = (CBool) CR2WTypeManager.Create("Bool", "areVoicesetGruntsEnabled", cr2w, this);
				}
				return _areVoicesetGruntsEnabled;
			}
			set
			{
				if (_areVoicesetGruntsEnabled == value)
				{
					return;
				}
				_areVoicesetGruntsEnabled = value;
				PropertySet(this);
			}
		}

		public scnVoicesetComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
