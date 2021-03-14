using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingTerminalControllerPS : ScriptableDeviceComponentPS
	{
		private VendingTerminalSetup _vendingTerminalSetup;
		private CBool _isReady;
		private CHandle<VendorDataManager> _vendorDataManager;

		[Ordinal(103)] 
		[RED("vendingTerminalSetup")] 
		public VendingTerminalSetup VendingTerminalSetup
		{
			get
			{
				if (_vendingTerminalSetup == null)
				{
					_vendingTerminalSetup = (VendingTerminalSetup) CR2WTypeManager.Create("VendingTerminalSetup", "vendingTerminalSetup", cr2w, this);
				}
				return _vendingTerminalSetup;
			}
			set
			{
				if (_vendingTerminalSetup == value)
				{
					return;
				}
				_vendingTerminalSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get
			{
				if (_isReady == null)
				{
					_isReady = (CBool) CR2WTypeManager.Create("Bool", "isReady", cr2w, this);
				}
				return _isReady;
			}
			set
			{
				if (_isReady == value)
				{
					return;
				}
				_isReady = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get
			{
				if (_vendorDataManager == null)
				{
					_vendorDataManager = (CHandle<VendorDataManager>) CR2WTypeManager.Create("handle:VendorDataManager", "VendorDataManager", cr2w, this);
				}
				return _vendorDataManager;
			}
			set
			{
				if (_vendorDataManager == value)
				{
					return;
				}
				_vendorDataManager = value;
				PropertySet(this);
			}
		}

		public VendingTerminalControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
