using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsTargetObjectPlayer : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _targetObject;

		[Ordinal(0)] 
		[RED("targetObject")] 
		public CHandle<AIArgumentMapping> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}
	}
}
