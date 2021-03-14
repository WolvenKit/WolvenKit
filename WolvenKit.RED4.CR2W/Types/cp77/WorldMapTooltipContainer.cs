using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipContainer : inkWidgetLogicController
	{
		private inkWidgetReference _defaultTooltip;
		private inkWidgetReference _policeTooltip;
		private inkWidgetReference _districtTooltip;
		private wCHandle<WorldMapTooltipBaseController> _defaultTooltipController;
		private wCHandle<WorldMapTooltipBaseController> _policeTooltipController;
		private wCHandle<WorldMapTooltipBaseController> _districtTooltipController;
		private CArrayFixedSize<wCHandle<WorldMapTooltipBaseController>> _tooltips;
		private CInt32 _currentVisibleIndex;

		[Ordinal(1)] 
		[RED("defaultTooltip")] 
		public inkWidgetReference DefaultTooltip
		{
			get
			{
				if (_defaultTooltip == null)
				{
					_defaultTooltip = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultTooltip", cr2w, this);
				}
				return _defaultTooltip;
			}
			set
			{
				if (_defaultTooltip == value)
				{
					return;
				}
				_defaultTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("policeTooltip")] 
		public inkWidgetReference PoliceTooltip
		{
			get
			{
				if (_policeTooltip == null)
				{
					_policeTooltip = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "policeTooltip", cr2w, this);
				}
				return _policeTooltip;
			}
			set
			{
				if (_policeTooltip == value)
				{
					return;
				}
				_policeTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("districtTooltip")] 
		public inkWidgetReference DistrictTooltip
		{
			get
			{
				if (_districtTooltip == null)
				{
					_districtTooltip = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "districtTooltip", cr2w, this);
				}
				return _districtTooltip;
			}
			set
			{
				if (_districtTooltip == value)
				{
					return;
				}
				_districtTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("defaultTooltipController")] 
		public wCHandle<WorldMapTooltipBaseController> DefaultTooltipController
		{
			get
			{
				if (_defaultTooltipController == null)
				{
					_defaultTooltipController = (wCHandle<WorldMapTooltipBaseController>) CR2WTypeManager.Create("whandle:WorldMapTooltipBaseController", "defaultTooltipController", cr2w, this);
				}
				return _defaultTooltipController;
			}
			set
			{
				if (_defaultTooltipController == value)
				{
					return;
				}
				_defaultTooltipController = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("policeTooltipController")] 
		public wCHandle<WorldMapTooltipBaseController> PoliceTooltipController
		{
			get
			{
				if (_policeTooltipController == null)
				{
					_policeTooltipController = (wCHandle<WorldMapTooltipBaseController>) CR2WTypeManager.Create("whandle:WorldMapTooltipBaseController", "policeTooltipController", cr2w, this);
				}
				return _policeTooltipController;
			}
			set
			{
				if (_policeTooltipController == value)
				{
					return;
				}
				_policeTooltipController = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("districtTooltipController")] 
		public wCHandle<WorldMapTooltipBaseController> DistrictTooltipController
		{
			get
			{
				if (_districtTooltipController == null)
				{
					_districtTooltipController = (wCHandle<WorldMapTooltipBaseController>) CR2WTypeManager.Create("whandle:WorldMapTooltipBaseController", "districtTooltipController", cr2w, this);
				}
				return _districtTooltipController;
			}
			set
			{
				if (_districtTooltipController == value)
				{
					return;
				}
				_districtTooltipController = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tooltips", 3)] 
		public CArrayFixedSize<wCHandle<WorldMapTooltipBaseController>> Tooltips
		{
			get
			{
				if (_tooltips == null)
				{
					_tooltips = (CArrayFixedSize<wCHandle<WorldMapTooltipBaseController>>) CR2WTypeManager.Create("[3]whandle:WorldMapTooltipBaseController", "tooltips", cr2w, this);
				}
				return _tooltips;
			}
			set
			{
				if (_tooltips == value)
				{
					return;
				}
				_tooltips = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("currentVisibleIndex")] 
		public CInt32 CurrentVisibleIndex
		{
			get
			{
				if (_currentVisibleIndex == null)
				{
					_currentVisibleIndex = (CInt32) CR2WTypeManager.Create("Int32", "currentVisibleIndex", cr2w, this);
				}
				return _currentVisibleIndex;
			}
			set
			{
				if (_currentVisibleIndex == value)
				{
					return;
				}
				_currentVisibleIndex = value;
				PropertySet(this);
			}
		}

		public WorldMapTooltipContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
