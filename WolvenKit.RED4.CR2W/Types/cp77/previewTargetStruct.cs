using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class previewTargetStruct : CVariable
	{
		private wCHandle<gameObject> _currentlyTrackedTarget;
		private CEnum<EHitReactionZone> _currentBodyPart;

		[Ordinal(0)] 
		[RED("currentlyTrackedTarget")] 
		public wCHandle<gameObject> CurrentlyTrackedTarget
		{
			get => GetProperty(ref _currentlyTrackedTarget);
			set => SetProperty(ref _currentlyTrackedTarget, value);
		}

		[Ordinal(1)] 
		[RED("currentBodyPart")] 
		public CEnum<EHitReactionZone> CurrentBodyPart
		{
			get => GetProperty(ref _currentBodyPart);
			set => SetProperty(ref _currentBodyPart, value);
		}

		public previewTargetStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
