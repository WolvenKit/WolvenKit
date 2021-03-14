using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsDetailViewController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statLabelRef;
		private inkTextWidgetReference _statValueRef;

		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get
			{
				if (_statLabelRef == null)
				{
					_statLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "StatLabelRef", cr2w, this);
				}
				return _statLabelRef;
			}
			set
			{
				if (_statLabelRef == value)
				{
					return;
				}
				_statLabelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("StatValueRef")] 
		public inkTextWidgetReference StatValueRef
		{
			get
			{
				if (_statValueRef == null)
				{
					_statValueRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "StatValueRef", cr2w, this);
				}
				return _statValueRef;
			}
			set
			{
				if (_statValueRef == value)
				{
					return;
				}
				_statValueRef = value;
				PropertySet(this);
			}
		}

		public StatsDetailViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
