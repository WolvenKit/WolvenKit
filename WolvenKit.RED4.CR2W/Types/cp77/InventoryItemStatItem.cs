using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemStatItem : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelText;
		private inkTextWidgetReference _valueText;
		private inkWidgetReference _differenceBarRef;
		private inkWidgetReference _diffrenceArrowIndicatorRef;
		private wCHandle<inkWidget> _root;
		private wCHandle<StatisticDifferenceBarController> _differenceBar;
		private CName _negativeState;
		private CName _positiveState;

		[Ordinal(1)] 
		[RED("labelText")] 
		public inkTextWidgetReference LabelText
		{
			get
			{
				if (_labelText == null)
				{
					_labelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelText", cr2w, this);
				}
				return _labelText;
			}
			set
			{
				if (_labelText == value)
				{
					return;
				}
				_labelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("valueText")] 
		public inkTextWidgetReference ValueText
		{
			get
			{
				if (_valueText == null)
				{
					_valueText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "valueText", cr2w, this);
				}
				return _valueText;
			}
			set
			{
				if (_valueText == value)
				{
					return;
				}
				_valueText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("differenceBarRef")] 
		public inkWidgetReference DifferenceBarRef
		{
			get
			{
				if (_differenceBarRef == null)
				{
					_differenceBarRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "differenceBarRef", cr2w, this);
				}
				return _differenceBarRef;
			}
			set
			{
				if (_differenceBarRef == value)
				{
					return;
				}
				_differenceBarRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("diffrenceArrowIndicatorRef")] 
		public inkWidgetReference DiffrenceArrowIndicatorRef
		{
			get
			{
				if (_diffrenceArrowIndicatorRef == null)
				{
					_diffrenceArrowIndicatorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "diffrenceArrowIndicatorRef", cr2w, this);
				}
				return _diffrenceArrowIndicatorRef;
			}
			set
			{
				if (_diffrenceArrowIndicatorRef == value)
				{
					return;
				}
				_diffrenceArrowIndicatorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("differenceBar")] 
		public wCHandle<StatisticDifferenceBarController> DifferenceBar
		{
			get
			{
				if (_differenceBar == null)
				{
					_differenceBar = (wCHandle<StatisticDifferenceBarController>) CR2WTypeManager.Create("whandle:StatisticDifferenceBarController", "differenceBar", cr2w, this);
				}
				return _differenceBar;
			}
			set
			{
				if (_differenceBar == value)
				{
					return;
				}
				_differenceBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("negativeState")] 
		public CName NegativeState
		{
			get
			{
				if (_negativeState == null)
				{
					_negativeState = (CName) CR2WTypeManager.Create("CName", "negativeState", cr2w, this);
				}
				return _negativeState;
			}
			set
			{
				if (_negativeState == value)
				{
					return;
				}
				_negativeState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("positiveState")] 
		public CName PositiveState
		{
			get
			{
				if (_positiveState == null)
				{
					_positiveState = (CName) CR2WTypeManager.Create("CName", "positiveState", cr2w, this);
				}
				return _positiveState;
			}
			set
			{
				if (_positiveState == value)
				{
					return;
				}
				_positiveState = value;
				PropertySet(this);
			}
		}

		public InventoryItemStatItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
