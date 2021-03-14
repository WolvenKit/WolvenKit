using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioParameterNodeType : questIAudioNodeType
	{
		private audioAudParameter _param;
		private CBool _isMusic;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;

		[Ordinal(0)] 
		[RED("param")] 
		public audioAudParameter Param
		{
			get
			{
				if (_param == null)
				{
					_param = (audioAudParameter) CR2WTypeManager.Create("audioAudParameter", "param", cr2w, this);
				}
				return _param;
			}
			set
			{
				if (_param == value)
				{
					return;
				}
				_param = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get
			{
				if (_isMusic == null)
				{
					_isMusic = (CBool) CR2WTypeManager.Create("Bool", "isMusic", cr2w, this);
				}
				return _isMusic;
			}
			set
			{
				if (_isMusic == value)
				{
					return;
				}
				_isMusic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		public questAudioParameterNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
