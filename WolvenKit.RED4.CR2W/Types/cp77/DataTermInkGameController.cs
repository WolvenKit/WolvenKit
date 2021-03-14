using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkHorizontalPanelWidget> _fcPointsPanel;
		private wCHandle<inkTextWidget> _districtText;
		private wCHandle<inkTextWidget> _pointText;
		private wCHandle<gameFastTravelPointData> _point;
		private CUInt32 _onFastTravelPointUpdateListener;

		[Ordinal(16)] 
		[RED("fcPointsPanel")] 
		public wCHandle<inkHorizontalPanelWidget> FcPointsPanel
		{
			get
			{
				if (_fcPointsPanel == null)
				{
					_fcPointsPanel = (wCHandle<inkHorizontalPanelWidget>) CR2WTypeManager.Create("whandle:inkHorizontalPanelWidget", "fcPointsPanel", cr2w, this);
				}
				return _fcPointsPanel;
			}
			set
			{
				if (_fcPointsPanel == value)
				{
					return;
				}
				_fcPointsPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("districtText")] 
		public wCHandle<inkTextWidget> DistrictText
		{
			get
			{
				if (_districtText == null)
				{
					_districtText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "districtText", cr2w, this);
				}
				return _districtText;
			}
			set
			{
				if (_districtText == value)
				{
					return;
				}
				_districtText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("pointText")] 
		public wCHandle<inkTextWidget> PointText
		{
			get
			{
				if (_pointText == null)
				{
					_pointText = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "pointText", cr2w, this);
				}
				return _pointText;
			}
			set
			{
				if (_pointText == value)
				{
					return;
				}
				_pointText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("point")] 
		public wCHandle<gameFastTravelPointData> Point
		{
			get
			{
				if (_point == null)
				{
					_point = (wCHandle<gameFastTravelPointData>) CR2WTypeManager.Create("whandle:gameFastTravelPointData", "point", cr2w, this);
				}
				return _point;
			}
			set
			{
				if (_point == value)
				{
					return;
				}
				_point = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("onFastTravelPointUpdateListener")] 
		public CUInt32 OnFastTravelPointUpdateListener
		{
			get
			{
				if (_onFastTravelPointUpdateListener == null)
				{
					_onFastTravelPointUpdateListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onFastTravelPointUpdateListener", cr2w, this);
				}
				return _onFastTravelPointUpdateListener;
			}
			set
			{
				if (_onFastTravelPointUpdateListener == value)
				{
					return;
				}
				_onFastTravelPointUpdateListener = value;
				PropertySet(this);
			}
		}

		public DataTermInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
