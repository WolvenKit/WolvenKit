using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitRepresentation_Raycast : gameEffectObjectFilter_HitRepresentation
	{
		private CBool _isPreview;
		private CBool _sendNearMissEvents;

		[Ordinal(0)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get => GetProperty(ref _isPreview);
			set => SetProperty(ref _isPreview, value);
		}

		[Ordinal(1)] 
		[RED("sendNearMissEvents")] 
		public CBool SendNearMissEvents
		{
			get => GetProperty(ref _sendNearMissEvents);
			set => SetProperty(ref _sendNearMissEvents, value);
		}

		public gameEffectObjectFilter_HitRepresentation_Raycast(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
