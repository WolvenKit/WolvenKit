using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataState : IScriptable
	{
		private CName _cPOMissionDataDamagesPreset;
		private CName _compatibleDeviceName;
		private CBool _ownerDecidesOnTransfer;
		private CBool _isChoiceToken;
		private CUInt32 _choiceTokenTimeout;
		private gameDelayID _delayedGiveChoiceTokenEventId;
		private CUInt32 _dataDamageTextLayerId;

		[Ordinal(0)] 
		[RED("CPOMissionDataDamagesPreset")] 
		public CName CPOMissionDataDamagesPreset
		{
			get
			{
				if (_cPOMissionDataDamagesPreset == null)
				{
					_cPOMissionDataDamagesPreset = (CName) CR2WTypeManager.Create("CName", "CPOMissionDataDamagesPreset", cr2w, this);
				}
				return _cPOMissionDataDamagesPreset;
			}
			set
			{
				if (_cPOMissionDataDamagesPreset == value)
				{
					return;
				}
				_cPOMissionDataDamagesPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get
			{
				if (_compatibleDeviceName == null)
				{
					_compatibleDeviceName = (CName) CR2WTypeManager.Create("CName", "compatibleDeviceName", cr2w, this);
				}
				return _compatibleDeviceName;
			}
			set
			{
				if (_compatibleDeviceName == value)
				{
					return;
				}
				_compatibleDeviceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get
			{
				if (_ownerDecidesOnTransfer == null)
				{
					_ownerDecidesOnTransfer = (CBool) CR2WTypeManager.Create("Bool", "ownerDecidesOnTransfer", cr2w, this);
				}
				return _ownerDecidesOnTransfer;
			}
			set
			{
				if (_ownerDecidesOnTransfer == value)
				{
					return;
				}
				_ownerDecidesOnTransfer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isChoiceToken")] 
		public CBool IsChoiceToken
		{
			get
			{
				if (_isChoiceToken == null)
				{
					_isChoiceToken = (CBool) CR2WTypeManager.Create("Bool", "isChoiceToken", cr2w, this);
				}
				return _isChoiceToken;
			}
			set
			{
				if (_isChoiceToken == value)
				{
					return;
				}
				_isChoiceToken = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("choiceTokenTimeout")] 
		public CUInt32 ChoiceTokenTimeout
		{
			get
			{
				if (_choiceTokenTimeout == null)
				{
					_choiceTokenTimeout = (CUInt32) CR2WTypeManager.Create("Uint32", "choiceTokenTimeout", cr2w, this);
				}
				return _choiceTokenTimeout;
			}
			set
			{
				if (_choiceTokenTimeout == value)
				{
					return;
				}
				_choiceTokenTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("delayedGiveChoiceTokenEventId")] 
		public gameDelayID DelayedGiveChoiceTokenEventId
		{
			get
			{
				if (_delayedGiveChoiceTokenEventId == null)
				{
					_delayedGiveChoiceTokenEventId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayedGiveChoiceTokenEventId", cr2w, this);
				}
				return _delayedGiveChoiceTokenEventId;
			}
			set
			{
				if (_delayedGiveChoiceTokenEventId == value)
				{
					return;
				}
				_delayedGiveChoiceTokenEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dataDamageTextLayerId")] 
		public CUInt32 DataDamageTextLayerId
		{
			get
			{
				if (_dataDamageTextLayerId == null)
				{
					_dataDamageTextLayerId = (CUInt32) CR2WTypeManager.Create("Uint32", "dataDamageTextLayerId", cr2w, this);
				}
				return _dataDamageTextLayerId;
			}
			set
			{
				if (_dataDamageTextLayerId == value)
				{
					return;
				}
				_dataDamageTextLayerId = value;
				PropertySet(this);
			}
		}

		public CPOMissionDataState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
