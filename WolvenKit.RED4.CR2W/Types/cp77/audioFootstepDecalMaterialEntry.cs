using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialEntry : CVariable
	{
		private CName _materialTag;
		private CHandle<audioLocomotionStateEventDictionary> _eventsByLocomotionState;

		[Ordinal(0)] 
		[RED("materialTag")] 
		public CName MaterialTag
		{
			get => GetProperty(ref _materialTag);
			set => SetProperty(ref _materialTag, value);
		}

		[Ordinal(1)] 
		[RED("eventsByLocomotionState")] 
		public CHandle<audioLocomotionStateEventDictionary> EventsByLocomotionState
		{
			get => GetProperty(ref _eventsByLocomotionState);
			set => SetProperty(ref _eventsByLocomotionState, value);
		}

		public audioFootstepDecalMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
