using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessBreach : PuppetAction
	{
		private CInt32 _attempt;
		private CString _networkName;
		private CInt32 _npcCount;
		private CBool _isRemote;
		private CBool _isSuicide;

		[Ordinal(25)] 
		[RED("attempt")] 
		public CInt32 Attempt
		{
			get
			{
				if (_attempt == null)
				{
					_attempt = (CInt32) CR2WTypeManager.Create("Int32", "attempt", cr2w, this);
				}
				return _attempt;
			}
			set
			{
				if (_attempt == value)
				{
					return;
				}
				_attempt = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("networkName")] 
		public CString NetworkName
		{
			get
			{
				if (_networkName == null)
				{
					_networkName = (CString) CR2WTypeManager.Create("String", "networkName", cr2w, this);
				}
				return _networkName;
			}
			set
			{
				if (_networkName == value)
				{
					return;
				}
				_networkName = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("npcCount")] 
		public CInt32 NpcCount
		{
			get
			{
				if (_npcCount == null)
				{
					_npcCount = (CInt32) CR2WTypeManager.Create("Int32", "npcCount", cr2w, this);
				}
				return _npcCount;
			}
			set
			{
				if (_npcCount == value)
				{
					return;
				}
				_npcCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get
			{
				if (_isRemote == null)
				{
					_isRemote = (CBool) CR2WTypeManager.Create("Bool", "isRemote", cr2w, this);
				}
				return _isRemote;
			}
			set
			{
				if (_isRemote == value)
				{
					return;
				}
				_isRemote = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("isSuicide")] 
		public CBool IsSuicide
		{
			get
			{
				if (_isSuicide == null)
				{
					_isSuicide = (CBool) CR2WTypeManager.Create("Bool", "isSuicide", cr2w, this);
				}
				return _isSuicide;
			}
			set
			{
				if (_isSuicide == value)
				{
					return;
				}
				_isSuicide = value;
				PropertySet(this);
			}
		}

		public AccessBreach(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
