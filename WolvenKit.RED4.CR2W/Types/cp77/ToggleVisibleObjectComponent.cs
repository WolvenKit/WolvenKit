using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleVisibleObjectComponent : StatusEffectTasks
	{
		private CBool _componentTargetState;
		private CName _visibleObjectDescription;

		[Ordinal(0)] 
		[RED("componentTargetState")] 
		public CBool ComponentTargetState
		{
			get
			{
				if (_componentTargetState == null)
				{
					_componentTargetState = (CBool) CR2WTypeManager.Create("Bool", "componentTargetState", cr2w, this);
				}
				return _componentTargetState;
			}
			set
			{
				if (_componentTargetState == value)
				{
					return;
				}
				_componentTargetState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visibleObjectDescription")] 
		public CName VisibleObjectDescription
		{
			get
			{
				if (_visibleObjectDescription == null)
				{
					_visibleObjectDescription = (CName) CR2WTypeManager.Create("CName", "visibleObjectDescription", cr2w, this);
				}
				return _visibleObjectDescription;
			}
			set
			{
				if (_visibleObjectDescription == value)
				{
					return;
				}
				_visibleObjectDescription = value;
				PropertySet(this);
			}
		}

		public ToggleVisibleObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
