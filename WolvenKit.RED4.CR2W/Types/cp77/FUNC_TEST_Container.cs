using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FUNC_TEST_Container : CVariable
	{
		private inkBasePanelWidgetReference _basePanel;
		private inkCompoundWidgetReference _compound;
		private inkLeafWidgetReference _leaf;
		private inkWidgetReference _widget;

		[Ordinal(0)] 
		[RED("BasePanel")] 
		public inkBasePanelWidgetReference BasePanel
		{
			get
			{
				if (_basePanel == null)
				{
					_basePanel = (inkBasePanelWidgetReference) CR2WTypeManager.Create("inkBasePanelWidgetReference", "BasePanel", cr2w, this);
				}
				return _basePanel;
			}
			set
			{
				if (_basePanel == value)
				{
					return;
				}
				_basePanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Compound")] 
		public inkCompoundWidgetReference Compound
		{
			get
			{
				if (_compound == null)
				{
					_compound = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "Compound", cr2w, this);
				}
				return _compound;
			}
			set
			{
				if (_compound == value)
				{
					return;
				}
				_compound = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Leaf")] 
		public inkLeafWidgetReference Leaf
		{
			get
			{
				if (_leaf == null)
				{
					_leaf = (inkLeafWidgetReference) CR2WTypeManager.Create("inkLeafWidgetReference", "Leaf", cr2w, this);
				}
				return _leaf;
			}
			set
			{
				if (_leaf == value)
				{
					return;
				}
				_leaf = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Widget")] 
		public inkWidgetReference Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		public FUNC_TEST_Container(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
