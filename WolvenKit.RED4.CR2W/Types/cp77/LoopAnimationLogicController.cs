using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoopAnimationLogicController : inkWidgetLogicController
	{
		private CName _defaultAnimation;
		private CEnum<inkSelectionRule> _selectionRule;

		[Ordinal(1)] 
		[RED("defaultAnimation")] 
		public CName DefaultAnimation
		{
			get
			{
				if (_defaultAnimation == null)
				{
					_defaultAnimation = (CName) CR2WTypeManager.Create("CName", "defaultAnimation", cr2w, this);
				}
				return _defaultAnimation;
			}
			set
			{
				if (_defaultAnimation == value)
				{
					return;
				}
				_defaultAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("selectionRule")] 
		public CEnum<inkSelectionRule> SelectionRule
		{
			get
			{
				if (_selectionRule == null)
				{
					_selectionRule = (CEnum<inkSelectionRule>) CR2WTypeManager.Create("inkSelectionRule", "selectionRule", cr2w, this);
				}
				return _selectionRule;
			}
			set
			{
				if (_selectionRule == value)
				{
					return;
				}
				_selectionRule = value;
				PropertySet(this);
			}
		}

		public LoopAnimationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
