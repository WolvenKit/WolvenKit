using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeThrowAttackEvents : MeleeAttackGenericEvents
	{
		private CBool _projectileThrown;
		private wCHandle<gameObject> _targetObject;

		[Ordinal(8)] 
		[RED("projectileThrown")] 
		public CBool ProjectileThrown
		{
			get => GetProperty(ref _projectileThrown);
			set => SetProperty(ref _projectileThrown, value);
		}

		[Ordinal(9)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		public MeleeThrowAttackEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
