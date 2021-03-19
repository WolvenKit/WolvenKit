using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsTargetObjectPlayer : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _targetObject;

		[Ordinal(0)] 
		[RED("targetObject")] 
		public CHandle<AIArgumentMapping> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		public IsTargetObjectPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
