using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questChangeVoicesetState_NodeTypeParams : CVariable
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enableVoicesetLines;
		private CBool _enableVoicesetGrunts;
		private CArray<entVoicesetInputToBlock> _inputsToBlock;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("enableVoicesetLines")] 
		public CBool EnableVoicesetLines
		{
			get
			{
				if (_enableVoicesetLines == null)
				{
					_enableVoicesetLines = (CBool) CR2WTypeManager.Create("Bool", "enableVoicesetLines", cr2w, this);
				}
				return _enableVoicesetLines;
			}
			set
			{
				if (_enableVoicesetLines == value)
				{
					return;
				}
				_enableVoicesetLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enableVoicesetGrunts")] 
		public CBool EnableVoicesetGrunts
		{
			get
			{
				if (_enableVoicesetGrunts == null)
				{
					_enableVoicesetGrunts = (CBool) CR2WTypeManager.Create("Bool", "enableVoicesetGrunts", cr2w, this);
				}
				return _enableVoicesetGrunts;
			}
			set
			{
				if (_enableVoicesetGrunts == value)
				{
					return;
				}
				_enableVoicesetGrunts = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("inputsToBlock")] 
		public CArray<entVoicesetInputToBlock> InputsToBlock
		{
			get
			{
				if (_inputsToBlock == null)
				{
					_inputsToBlock = (CArray<entVoicesetInputToBlock>) CR2WTypeManager.Create("array:entVoicesetInputToBlock", "inputsToBlock", cr2w, this);
				}
				return _inputsToBlock;
			}
			set
			{
				if (_inputsToBlock == value)
				{
					return;
				}
				_inputsToBlock = value;
				PropertySet(this);
			}
		}

		public questChangeVoicesetState_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
