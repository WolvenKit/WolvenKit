using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeThrowAttackEvents : MeleeAttackGenericEvents
	{
		private CBool _projectileThrown;
		private CWeakHandle<gameObject> _targetObject;

		[Ordinal(8)] 
		[RED("projectileThrown")] 
		public CBool ProjectileThrown
		{
			get => GetProperty(ref _projectileThrown);
			set => SetProperty(ref _projectileThrown, value);
		}

		[Ordinal(9)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}
	}
}
