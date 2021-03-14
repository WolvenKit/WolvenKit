using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStepperController : inkWidgetLogicController
	{
		private CBool _cycledNavigation;
		private CName _indicatorUnitLibraryID;
		private inkTextWidgetReference _currentValueDisplay;
		private inkCompoundWidgetReference _indicatorContainer;
		private inkWidgetReference _leftButton;
		private inkWidgetReference _rightButton;
		private inkStepperChangedCallback _change;

		[Ordinal(1)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get
			{
				if (_cycledNavigation == null)
				{
					_cycledNavigation = (CBool) CR2WTypeManager.Create("Bool", "cycledNavigation", cr2w, this);
				}
				return _cycledNavigation;
			}
			set
			{
				if (_cycledNavigation == value)
				{
					return;
				}
				_cycledNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("indicatorUnitLibraryID")] 
		public CName IndicatorUnitLibraryID
		{
			get
			{
				if (_indicatorUnitLibraryID == null)
				{
					_indicatorUnitLibraryID = (CName) CR2WTypeManager.Create("CName", "indicatorUnitLibraryID", cr2w, this);
				}
				return _indicatorUnitLibraryID;
			}
			set
			{
				if (_indicatorUnitLibraryID == value)
				{
					return;
				}
				_indicatorUnitLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentValueDisplay")] 
		public inkTextWidgetReference CurrentValueDisplay
		{
			get
			{
				if (_currentValueDisplay == null)
				{
					_currentValueDisplay = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentValueDisplay", cr2w, this);
				}
				return _currentValueDisplay;
			}
			set
			{
				if (_currentValueDisplay == value)
				{
					return;
				}
				_currentValueDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("indicatorContainer")] 
		public inkCompoundWidgetReference IndicatorContainer
		{
			get
			{
				if (_indicatorContainer == null)
				{
					_indicatorContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "indicatorContainer", cr2w, this);
				}
				return _indicatorContainer;
			}
			set
			{
				if (_indicatorContainer == value)
				{
					return;
				}
				_indicatorContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("leftButton")] 
		public inkWidgetReference LeftButton
		{
			get
			{
				if (_leftButton == null)
				{
					_leftButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "leftButton", cr2w, this);
				}
				return _leftButton;
			}
			set
			{
				if (_leftButton == value)
				{
					return;
				}
				_leftButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rightButton")] 
		public inkWidgetReference RightButton
		{
			get
			{
				if (_rightButton == null)
				{
					_rightButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rightButton", cr2w, this);
				}
				return _rightButton;
			}
			set
			{
				if (_rightButton == value)
				{
					return;
				}
				_rightButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Change")] 
		public inkStepperChangedCallback Change
		{
			get
			{
				if (_change == null)
				{
					_change = (inkStepperChangedCallback) CR2WTypeManager.Create("inkStepperChangedCallback", "Change", cr2w, this);
				}
				return _change;
			}
			set
			{
				if (_change == value)
				{
					return;
				}
				_change = value;
				PropertySet(this);
			}
		}

		public inkStepperController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
