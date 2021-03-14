using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsProgressController : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelRef;
		private inkTextWidgetReference _currentXpRef;
		private inkTextWidgetReference _maxXpRef;
		private inkTextWidgetReference _currentLevelRef;
		private inkTextWidgetReference _currentPersentageRef;
		private inkWidgetReference _xpWrapper;
		private inkWidgetReference _maxXpWrapper;
		private inkWidgetReference _progressBarFill;
		private inkWidgetReference _progressBar;
		private inkWidgetReference _progressMarkerBar;
		private CFloat _barLenght;

		[Ordinal(1)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get
			{
				if (_labelRef == null)
				{
					_labelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelRef", cr2w, this);
				}
				return _labelRef;
			}
			set
			{
				if (_labelRef == value)
				{
					return;
				}
				_labelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentXpRef")] 
		public inkTextWidgetReference CurrentXpRef
		{
			get
			{
				if (_currentXpRef == null)
				{
					_currentXpRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentXpRef", cr2w, this);
				}
				return _currentXpRef;
			}
			set
			{
				if (_currentXpRef == value)
				{
					return;
				}
				_currentXpRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxXpRef")] 
		public inkTextWidgetReference MaxXpRef
		{
			get
			{
				if (_maxXpRef == null)
				{
					_maxXpRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "maxXpRef", cr2w, this);
				}
				return _maxXpRef;
			}
			set
			{
				if (_maxXpRef == value)
				{
					return;
				}
				_maxXpRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentLevelRef")] 
		public inkTextWidgetReference CurrentLevelRef
		{
			get
			{
				if (_currentLevelRef == null)
				{
					_currentLevelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentLevelRef", cr2w, this);
				}
				return _currentLevelRef;
			}
			set
			{
				if (_currentLevelRef == value)
				{
					return;
				}
				_currentLevelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("currentPersentageRef")] 
		public inkTextWidgetReference CurrentPersentageRef
		{
			get
			{
				if (_currentPersentageRef == null)
				{
					_currentPersentageRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentPersentageRef", cr2w, this);
				}
				return _currentPersentageRef;
			}
			set
			{
				if (_currentPersentageRef == value)
				{
					return;
				}
				_currentPersentageRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("XpWrapper")] 
		public inkWidgetReference XpWrapper
		{
			get
			{
				if (_xpWrapper == null)
				{
					_xpWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "XpWrapper", cr2w, this);
				}
				return _xpWrapper;
			}
			set
			{
				if (_xpWrapper == value)
				{
					return;
				}
				_xpWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxXpWrapper")] 
		public inkWidgetReference MaxXpWrapper
		{
			get
			{
				if (_maxXpWrapper == null)
				{
					_maxXpWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "maxXpWrapper", cr2w, this);
				}
				return _maxXpWrapper;
			}
			set
			{
				if (_maxXpWrapper == value)
				{
					return;
				}
				_maxXpWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("progressBarFill")] 
		public inkWidgetReference ProgressBarFill
		{
			get
			{
				if (_progressBarFill == null)
				{
					_progressBarFill = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBarFill", cr2w, this);
				}
				return _progressBarFill;
			}
			set
			{
				if (_progressBarFill == value)
				{
					return;
				}
				_progressBarFill = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get
			{
				if (_progressBar == null)
				{
					_progressBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressBar", cr2w, this);
				}
				return _progressBar;
			}
			set
			{
				if (_progressBar == value)
				{
					return;
				}
				_progressBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("progressMarkerBar")] 
		public inkWidgetReference ProgressMarkerBar
		{
			get
			{
				if (_progressMarkerBar == null)
				{
					_progressMarkerBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "progressMarkerBar", cr2w, this);
				}
				return _progressMarkerBar;
			}
			set
			{
				if (_progressMarkerBar == value)
				{
					return;
				}
				_progressMarkerBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("barLenght")] 
		public CFloat BarLenght
		{
			get
			{
				if (_barLenght == null)
				{
					_barLenght = (CFloat) CR2WTypeManager.Create("Float", "barLenght", cr2w, this);
				}
				return _barLenght;
			}
			set
			{
				if (_barLenght == value)
				{
					return;
				}
				_barLenght = value;
				PropertySet(this);
			}
		}

		public StatsProgressController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
