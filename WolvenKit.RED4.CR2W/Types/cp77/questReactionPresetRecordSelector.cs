using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questReactionPresetRecordSelector : ISerializable
	{
		private CBool _setDefault;
		private CBool _isGanger;
		private TweakDBID _gangerRecordID;
		private CBool _isCivilian;
		private TweakDBID _civilianRecordID;
		private CBool _isCorpo;
		private TweakDBID _corpoRecordID;
		private CBool _isPolice;
		private TweakDBID _policeRecordID;
		private CBool _isMechanical;
		private TweakDBID _mechanicalRecordID;
		private CBool _isNoReaction;
		private TweakDBID _noReactionRecordID;

		[Ordinal(0)] 
		[RED("setDefault")] 
		public CBool SetDefault
		{
			get
			{
				if (_setDefault == null)
				{
					_setDefault = (CBool) CR2WTypeManager.Create("Bool", "setDefault", cr2w, this);
				}
				return _setDefault;
			}
			set
			{
				if (_setDefault == value)
				{
					return;
				}
				_setDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isGanger")] 
		public CBool IsGanger
		{
			get
			{
				if (_isGanger == null)
				{
					_isGanger = (CBool) CR2WTypeManager.Create("Bool", "isGanger", cr2w, this);
				}
				return _isGanger;
			}
			set
			{
				if (_isGanger == value)
				{
					return;
				}
				_isGanger = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gangerRecordID")] 
		public TweakDBID GangerRecordID
		{
			get
			{
				if (_gangerRecordID == null)
				{
					_gangerRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "gangerRecordID", cr2w, this);
				}
				return _gangerRecordID;
			}
			set
			{
				if (_gangerRecordID == value)
				{
					return;
				}
				_gangerRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get
			{
				if (_isCivilian == null)
				{
					_isCivilian = (CBool) CR2WTypeManager.Create("Bool", "isCivilian", cr2w, this);
				}
				return _isCivilian;
			}
			set
			{
				if (_isCivilian == value)
				{
					return;
				}
				_isCivilian = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("civilianRecordID")] 
		public TweakDBID CivilianRecordID
		{
			get
			{
				if (_civilianRecordID == null)
				{
					_civilianRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "civilianRecordID", cr2w, this);
				}
				return _civilianRecordID;
			}
			set
			{
				if (_civilianRecordID == value)
				{
					return;
				}
				_civilianRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isCorpo")] 
		public CBool IsCorpo
		{
			get
			{
				if (_isCorpo == null)
				{
					_isCorpo = (CBool) CR2WTypeManager.Create("Bool", "isCorpo", cr2w, this);
				}
				return _isCorpo;
			}
			set
			{
				if (_isCorpo == value)
				{
					return;
				}
				_isCorpo = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("corpoRecordID")] 
		public TweakDBID CorpoRecordID
		{
			get
			{
				if (_corpoRecordID == null)
				{
					_corpoRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "corpoRecordID", cr2w, this);
				}
				return _corpoRecordID;
			}
			set
			{
				if (_corpoRecordID == value)
				{
					return;
				}
				_corpoRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isPolice")] 
		public CBool IsPolice
		{
			get
			{
				if (_isPolice == null)
				{
					_isPolice = (CBool) CR2WTypeManager.Create("Bool", "isPolice", cr2w, this);
				}
				return _isPolice;
			}
			set
			{
				if (_isPolice == value)
				{
					return;
				}
				_isPolice = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("policeRecordID")] 
		public TweakDBID PoliceRecordID
		{
			get
			{
				if (_policeRecordID == null)
				{
					_policeRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "policeRecordID", cr2w, this);
				}
				return _policeRecordID;
			}
			set
			{
				if (_policeRecordID == value)
				{
					return;
				}
				_policeRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isMechanical")] 
		public CBool IsMechanical
		{
			get
			{
				if (_isMechanical == null)
				{
					_isMechanical = (CBool) CR2WTypeManager.Create("Bool", "isMechanical", cr2w, this);
				}
				return _isMechanical;
			}
			set
			{
				if (_isMechanical == value)
				{
					return;
				}
				_isMechanical = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("mechanicalRecordID")] 
		public TweakDBID MechanicalRecordID
		{
			get
			{
				if (_mechanicalRecordID == null)
				{
					_mechanicalRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "mechanicalRecordID", cr2w, this);
				}
				return _mechanicalRecordID;
			}
			set
			{
				if (_mechanicalRecordID == value)
				{
					return;
				}
				_mechanicalRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isNoReaction")] 
		public CBool IsNoReaction
		{
			get
			{
				if (_isNoReaction == null)
				{
					_isNoReaction = (CBool) CR2WTypeManager.Create("Bool", "isNoReaction", cr2w, this);
				}
				return _isNoReaction;
			}
			set
			{
				if (_isNoReaction == value)
				{
					return;
				}
				_isNoReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("noReactionRecordID")] 
		public TweakDBID NoReactionRecordID
		{
			get
			{
				if (_noReactionRecordID == null)
				{
					_noReactionRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "noReactionRecordID", cr2w, this);
				}
				return _noReactionRecordID;
			}
			set
			{
				if (_noReactionRecordID == value)
				{
					return;
				}
				_noReactionRecordID = value;
				PropertySet(this);
			}
		}

		public questReactionPresetRecordSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
