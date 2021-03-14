using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataTransferred : redEvent
	{
		private CBool _dataDownloaded;
		private CName _dataDamagesPresetName;
		private CName _compatibleDeviceName;
		private CBool _ownerDecidesOnTransfer;
		private CBool _isChoiceToken;
		private CUInt32 _choiceTokenTimeout;

		[Ordinal(0)] 
		[RED("dataDownloaded")] 
		public CBool DataDownloaded
		{
			get
			{
				if (_dataDownloaded == null)
				{
					_dataDownloaded = (CBool) CR2WTypeManager.Create("Bool", "dataDownloaded", cr2w, this);
				}
				return _dataDownloaded;
			}
			set
			{
				if (_dataDownloaded == value)
				{
					return;
				}
				_dataDownloaded = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dataDamagesPresetName")] 
		public CName DataDamagesPresetName
		{
			get
			{
				if (_dataDamagesPresetName == null)
				{
					_dataDamagesPresetName = (CName) CR2WTypeManager.Create("CName", "dataDamagesPresetName", cr2w, this);
				}
				return _dataDamagesPresetName;
			}
			set
			{
				if (_dataDamagesPresetName == value)
				{
					return;
				}
				_dataDamagesPresetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public CPOMissionDataTransferred(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
