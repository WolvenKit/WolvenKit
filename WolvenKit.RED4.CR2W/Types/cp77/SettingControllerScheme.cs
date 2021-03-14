using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingControllerScheme : inkWidgetLogicController
	{
		private inkWidgetReference _tabRootRef;
		private inkWidgetReference _inputTab;
		private inkWidgetReference _vehiclesTab;
		private inkWidgetReference _braindanceTab;
		private CHandle<TabRadioGroup> _tabRoot;

		[Ordinal(1)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get
			{
				if (_tabRootRef == null)
				{
					_tabRootRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tabRootRef", cr2w, this);
				}
				return _tabRootRef;
			}
			set
			{
				if (_tabRootRef == value)
				{
					return;
				}
				_tabRootRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputTab")] 
		public inkWidgetReference InputTab
		{
			get
			{
				if (_inputTab == null)
				{
					_inputTab = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputTab", cr2w, this);
				}
				return _inputTab;
			}
			set
			{
				if (_inputTab == value)
				{
					return;
				}
				_inputTab = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vehiclesTab")] 
		public inkWidgetReference VehiclesTab
		{
			get
			{
				if (_vehiclesTab == null)
				{
					_vehiclesTab = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehiclesTab", cr2w, this);
				}
				return _vehiclesTab;
			}
			set
			{
				if (_vehiclesTab == value)
				{
					return;
				}
				_vehiclesTab = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("braindanceTab")] 
		public inkWidgetReference BraindanceTab
		{
			get
			{
				if (_braindanceTab == null)
				{
					_braindanceTab = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "braindanceTab", cr2w, this);
				}
				return _braindanceTab;
			}
			set
			{
				if (_braindanceTab == value)
				{
					return;
				}
				_braindanceTab = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tabRoot")] 
		public CHandle<TabRadioGroup> TabRoot
		{
			get
			{
				if (_tabRoot == null)
				{
					_tabRoot = (CHandle<TabRadioGroup>) CR2WTypeManager.Create("handle:TabRadioGroup", "tabRoot", cr2w, this);
				}
				return _tabRoot;
			}
			set
			{
				if (_tabRoot == value)
				{
					return;
				}
				_tabRoot = value;
				PropertySet(this);
			}
		}

		public SettingControllerScheme(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
