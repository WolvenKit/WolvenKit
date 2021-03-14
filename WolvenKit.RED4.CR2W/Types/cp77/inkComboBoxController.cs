using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkComboBoxController : inkWidgetLogicController
	{
		private inkWidgetReference _comboBoxObjectRef;
		private inkComboBoxVisibleChangedCallback _comboBoxVisibleChanged;

		[Ordinal(1)] 
		[RED("comboBoxObjectRef")] 
		public inkWidgetReference ComboBoxObjectRef
		{
			get
			{
				if (_comboBoxObjectRef == null)
				{
					_comboBoxObjectRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "comboBoxObjectRef", cr2w, this);
				}
				return _comboBoxObjectRef;
			}
			set
			{
				if (_comboBoxObjectRef == value)
				{
					return;
				}
				_comboBoxObjectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ComboBoxVisibleChanged")] 
		public inkComboBoxVisibleChangedCallback ComboBoxVisibleChanged
		{
			get
			{
				if (_comboBoxVisibleChanged == null)
				{
					_comboBoxVisibleChanged = (inkComboBoxVisibleChangedCallback) CR2WTypeManager.Create("inkComboBoxVisibleChangedCallback", "ComboBoxVisibleChanged", cr2w, this);
				}
				return _comboBoxVisibleChanged;
			}
			set
			{
				if (_comboBoxVisibleChanged == value)
				{
					return;
				}
				_comboBoxVisibleChanged = value;
				PropertySet(this);
			}
		}

		public inkComboBoxController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
