using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperationBase : IScriptable
	{
		private CName _operationName;
		private CBool _executeOnce;
		private CBool _isEnabled;
		private CArray<SToggleDeviceOperationData> _toggleOperations;
		private CBool _disableDevice;

		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get
			{
				if (_operationName == null)
				{
					_operationName = (CName) CR2WTypeManager.Create("CName", "operationName", cr2w, this);
				}
				return _operationName;
			}
			set
			{
				if (_operationName == value)
				{
					return;
				}
				_operationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("executeOnce")] 
		public CBool ExecuteOnce
		{
			get
			{
				if (_executeOnce == null)
				{
					_executeOnce = (CBool) CR2WTypeManager.Create("Bool", "executeOnce", cr2w, this);
				}
				return _executeOnce;
			}
			set
			{
				if (_executeOnce == value)
				{
					return;
				}
				_executeOnce = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("toggleOperations")] 
		public CArray<SToggleDeviceOperationData> ToggleOperations
		{
			get
			{
				if (_toggleOperations == null)
				{
					_toggleOperations = (CArray<SToggleDeviceOperationData>) CR2WTypeManager.Create("array:SToggleDeviceOperationData", "toggleOperations", cr2w, this);
				}
				return _toggleOperations;
			}
			set
			{
				if (_toggleOperations == value)
				{
					return;
				}
				_toggleOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("disableDevice")] 
		public CBool DisableDevice
		{
			get
			{
				if (_disableDevice == null)
				{
					_disableDevice = (CBool) CR2WTypeManager.Create("Bool", "disableDevice", cr2w, this);
				}
				return _disableDevice;
			}
			set
			{
				if (_disableDevice == value)
				{
					return;
				}
				_disableDevice = value;
				PropertySet(this);
			}
		}

		public DeviceOperationBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
