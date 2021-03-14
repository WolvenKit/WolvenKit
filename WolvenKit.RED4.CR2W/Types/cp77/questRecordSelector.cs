using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRecordSelector : ISerializable
	{
		private CBool _isCharacter;
		private TweakDBID _characterRecordID;
		private CBool _isDevice;
		private TweakDBID _deviceRecordID;
		private CBool _isItem;
		private TweakDBID _itemRecordID;

		[Ordinal(0)] 
		[RED("isCharacter")] 
		public CBool IsCharacter
		{
			get
			{
				if (_isCharacter == null)
				{
					_isCharacter = (CBool) CR2WTypeManager.Create("Bool", "isCharacter", cr2w, this);
				}
				return _isCharacter;
			}
			set
			{
				if (_isCharacter == value)
				{
					return;
				}
				_isCharacter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("characterRecordID")] 
		public TweakDBID CharacterRecordID
		{
			get
			{
				if (_characterRecordID == null)
				{
					_characterRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "characterRecordID", cr2w, this);
				}
				return _characterRecordID;
			}
			set
			{
				if (_characterRecordID == value)
				{
					return;
				}
				_characterRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get
			{
				if (_isDevice == null)
				{
					_isDevice = (CBool) CR2WTypeManager.Create("Bool", "isDevice", cr2w, this);
				}
				return _isDevice;
			}
			set
			{
				if (_isDevice == value)
				{
					return;
				}
				_isDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("deviceRecordID")] 
		public TweakDBID DeviceRecordID
		{
			get
			{
				if (_deviceRecordID == null)
				{
					_deviceRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "deviceRecordID", cr2w, this);
				}
				return _deviceRecordID;
			}
			set
			{
				if (_deviceRecordID == value)
				{
					return;
				}
				_deviceRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isItem")] 
		public CBool IsItem
		{
			get
			{
				if (_isItem == null)
				{
					_isItem = (CBool) CR2WTypeManager.Create("Bool", "isItem", cr2w, this);
				}
				return _isItem;
			}
			set
			{
				if (_isItem == value)
				{
					return;
				}
				_isItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemRecordID")] 
		public TweakDBID ItemRecordID
		{
			get
			{
				if (_itemRecordID == null)
				{
					_itemRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemRecordID", cr2w, this);
				}
				return _itemRecordID;
			}
			set
			{
				if (_itemRecordID == value)
				{
					return;
				}
				_itemRecordID = value;
				PropertySet(this);
			}
		}

		public questRecordSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
