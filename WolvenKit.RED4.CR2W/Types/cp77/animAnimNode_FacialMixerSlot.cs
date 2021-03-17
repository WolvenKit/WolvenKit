using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FacialMixerSlot : animAnimNode_OnePoseInput
	{
		private CArray<animLookAtAnimationDefinition> _lookAtDefinitions;

		[Ordinal(12)] 
		[RED("lookAtDefinitions")] 
		public CArray<animLookAtAnimationDefinition> LookAtDefinitions
		{
			get => GetProperty(ref _lookAtDefinitions);
			set => SetProperty(ref _lookAtDefinitions, value);
		}

		public animAnimNode_FacialMixerSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
