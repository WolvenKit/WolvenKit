using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModeGridContainer : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _scrollControllerWidget;
		private inkWidgetReference _sliderWidget;
		private inkWidgetReference _itemsGridWidget;
		private inkCompoundWidgetReference _filterGridWidget;
		private inkWidgetReference _f_eyesTexture;
		private inkWidgetReference _f_systemReplacementTexture;
		private inkWidgetReference _f_handsTexture;
		private inkWidgetReference _m_eyesTexture;
		private inkWidgetReference _m_systemReplacementTexture;
		private inkWidgetReference _m_handsTexture;
		private CHandle<inkanimProxy> _outroAnimation;

		[Ordinal(1)] 
		[RED("scrollControllerWidget")] 
		public inkCompoundWidgetReference ScrollControllerWidget
		{
			get
			{
				if (_scrollControllerWidget == null)
				{
					_scrollControllerWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scrollControllerWidget", cr2w, this);
				}
				return _scrollControllerWidget;
			}
			set
			{
				if (_scrollControllerWidget == value)
				{
					return;
				}
				_scrollControllerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get
			{
				if (_sliderWidget == null)
				{
					_sliderWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sliderWidget", cr2w, this);
				}
				return _sliderWidget;
			}
			set
			{
				if (_sliderWidget == value)
				{
					return;
				}
				_sliderWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemsGridWidget")] 
		public inkWidgetReference ItemsGridWidget
		{
			get
			{
				if (_itemsGridWidget == null)
				{
					_itemsGridWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemsGridWidget", cr2w, this);
				}
				return _itemsGridWidget;
			}
			set
			{
				if (_itemsGridWidget == value)
				{
					return;
				}
				_itemsGridWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("filterGridWidget")] 
		public inkCompoundWidgetReference FilterGridWidget
		{
			get
			{
				if (_filterGridWidget == null)
				{
					_filterGridWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "filterGridWidget", cr2w, this);
				}
				return _filterGridWidget;
			}
			set
			{
				if (_filterGridWidget == value)
				{
					return;
				}
				_filterGridWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("F_eyesTexture")] 
		public inkWidgetReference F_eyesTexture
		{
			get
			{
				if (_f_eyesTexture == null)
				{
					_f_eyesTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_eyesTexture", cr2w, this);
				}
				return _f_eyesTexture;
			}
			set
			{
				if (_f_eyesTexture == value)
				{
					return;
				}
				_f_eyesTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("F_systemReplacementTexture")] 
		public inkWidgetReference F_systemReplacementTexture
		{
			get
			{
				if (_f_systemReplacementTexture == null)
				{
					_f_systemReplacementTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_systemReplacementTexture", cr2w, this);
				}
				return _f_systemReplacementTexture;
			}
			set
			{
				if (_f_systemReplacementTexture == value)
				{
					return;
				}
				_f_systemReplacementTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("F_handsTexture")] 
		public inkWidgetReference F_handsTexture
		{
			get
			{
				if (_f_handsTexture == null)
				{
					_f_handsTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "F_handsTexture", cr2w, this);
				}
				return _f_handsTexture;
			}
			set
			{
				if (_f_handsTexture == value)
				{
					return;
				}
				_f_handsTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("M_eyesTexture")] 
		public inkWidgetReference M_eyesTexture
		{
			get
			{
				if (_m_eyesTexture == null)
				{
					_m_eyesTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_eyesTexture", cr2w, this);
				}
				return _m_eyesTexture;
			}
			set
			{
				if (_m_eyesTexture == value)
				{
					return;
				}
				_m_eyesTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("M_systemReplacementTexture")] 
		public inkWidgetReference M_systemReplacementTexture
		{
			get
			{
				if (_m_systemReplacementTexture == null)
				{
					_m_systemReplacementTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_systemReplacementTexture", cr2w, this);
				}
				return _m_systemReplacementTexture;
			}
			set
			{
				if (_m_systemReplacementTexture == value)
				{
					return;
				}
				_m_systemReplacementTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("M_handsTexture")] 
		public inkWidgetReference M_handsTexture
		{
			get
			{
				if (_m_handsTexture == null)
				{
					_m_handsTexture = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "M_handsTexture", cr2w, this);
				}
				return _m_handsTexture;
			}
			set
			{
				if (_m_handsTexture == value)
				{
					return;
				}
				_m_handsTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("outroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get
			{
				if (_outroAnimation == null)
				{
					_outroAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "outroAnimation", cr2w, this);
				}
				return _outroAnimation;
			}
			set
			{
				if (_outroAnimation == value)
				{
					return;
				}
				_outroAnimation = value;
				PropertySet(this);
			}
		}

		public ItemModeGridContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
