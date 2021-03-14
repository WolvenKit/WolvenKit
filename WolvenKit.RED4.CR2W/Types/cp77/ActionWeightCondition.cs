using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionWeightCondition : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _selectedActionIndex;
		private CInt32 _thisIndex;

		[Ordinal(0)] 
		[RED("selectedActionIndex")] 
		public CHandle<AIArgumentMapping> SelectedActionIndex
		{
			get
			{
				if (_selectedActionIndex == null)
				{
					_selectedActionIndex = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "selectedActionIndex", cr2w, this);
				}
				return _selectedActionIndex;
			}
			set
			{
				if (_selectedActionIndex == value)
				{
					return;
				}
				_selectedActionIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("thisIndex")] 
		public CInt32 ThisIndex
		{
			get
			{
				if (_thisIndex == null)
				{
					_thisIndex = (CInt32) CR2WTypeManager.Create("Int32", "thisIndex", cr2w, this);
				}
				return _thisIndex;
			}
			set
			{
				if (_thisIndex == value)
				{
					return;
				}
				_thisIndex = value;
				PropertySet(this);
			}
		}

		public ActionWeightCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
