using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceConnectionScannerData : CVariable
	{
		private CString _connectionType;
		private CName _icon;
		private CInt32 _amount;

		[Ordinal(0)] 
		[RED("connectionType")] 
		public CString ConnectionType
		{
			get
			{
				if (_connectionType == null)
				{
					_connectionType = (CString) CR2WTypeManager.Create("String", "connectionType", cr2w, this);
				}
				return _connectionType;
			}
			set
			{
				if (_connectionType == value)
				{
					return;
				}
				_connectionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("icon")] 
		public CName Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (CName) CR2WTypeManager.Create("CName", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CInt32) CR2WTypeManager.Create("Int32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		public DeviceConnectionScannerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
