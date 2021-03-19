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
			get => GetProperty(ref _targetingEntity);
			set => SetProperty(ref _targetingEntity, value);
		}

		public gametargetingSystemEntityTargetedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
