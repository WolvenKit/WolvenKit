using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemEntityTargetedEvent : redEvent
	{
		private wCHandle<entEntity> _targetingEntity;

		[Ordinal(0)] 
		[RED("targetingEntity")] 
		public wCHandle<entEntity> TargetingEntity
		{
			get
			{
				if (_targetingEntity == null)
				{
					_targetingEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "targetingEntity", cr2w, this);
				}
				return _targetingEntity;
			}
			set
			{
				if (_targetingEntity == value)
				{
					return;
				}
				_targetingEntity = value;
				PropertySet(this);
			}
		}

		public gametargetingSystemEntityTargetedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
