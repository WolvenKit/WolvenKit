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
			get => GetProperty(ref _componentTargetState);
			set => SetProperty(ref _componentTargetState, value);
		}

		[Ordinal(1)] 
		[RED("visibleObjectDescription")] 
		public CName VisibleObjectDescription
		{
			get => GetProperty(ref _visibleObjectDescription);
			set => SetProperty(ref _visibleObjectDescription, value);
		}

		public ToggleVisibleObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
