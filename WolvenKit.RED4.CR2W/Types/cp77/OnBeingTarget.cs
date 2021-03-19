using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnBeingTarget : redEvent
	{
		private wCHandle<gameObject> _objectThatTargets;
		private CBool _noLongerTarget;

		[Ordinal(0)] 
		[RED("objectThatTargets")] 
		public wCHandle<gameObject> ObjectThatTargets
		{
			get => GetProperty(ref _objectThatTargets);
			set => SetProperty(ref _objectThatTargets, value);
		}

		[Ordinal(1)] 
		[RED("noLongerTarget")] 
		public CBool NoLongerTarget
		{
			get => GetProperty(ref _noLongerTarget);
			set => SetProperty(ref _noLongerTarget, value);
		}

		public OnBeingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
