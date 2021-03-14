using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPrereq : gameIScriptablePrereq
	{
		private TweakDBID _statusEffectRecordID;
		private CName _tag;
		private CString _checkType;
		private CBool _invert;
		private CBool _fireAndForget;

		[Ordinal(0)] 
		[RED("statusEffectRecordID")] 
		public TweakDBID StatusEffectRecordID
		{
			get
			{
				if (_statusEffectRecordID == null)
				{
					_statusEffectRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectRecordID", cr2w, this);
				}
				return _statusEffectRecordID;
			}
			set
			{
				if (_statusEffectRecordID == value)
				{
					return;
				}
				_statusEffectRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("checkType")] 
		public CString CheckType
		{
			get
			{
				if (_checkType == null)
				{
					_checkType = (CString) CR2WTypeManager.Create("String", "checkType", cr2w, this);
				}
				return _checkType;
			}
			set
			{
				if (_checkType == value)
				{
					return;
				}
				_checkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get
			{
				if (_fireAndForget == null)
				{
					_fireAndForget = (CBool) CR2WTypeManager.Create("Bool", "fireAndForget", cr2w, this);
				}
				return _fireAndForget;
			}
			set
			{
				if (_fireAndForget == value)
				{
					return;
				}
				_fireAndForget = value;
				PropertySet(this);
			}
		}

		public StatusEffectPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
