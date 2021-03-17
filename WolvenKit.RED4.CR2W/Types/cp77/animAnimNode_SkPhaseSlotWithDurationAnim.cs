using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseSlotWithDurationAnim : animAnimNode_SkPhaseWithDurationAnim
	{
		private CName _animFeatureName;
		private rRef<animActionAnimDatabase> _actionAnimDatabaseRef;

		[Ordinal(32)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(33)] 
		[RED("actionAnimDatabaseRef")] 
		public rRef<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get => GetProperty(ref _actionAnimDatabaseRef);
			set => SetProperty(ref _actionAnimDatabaseRef, value);
		}

		public animAnimNode_SkPhaseSlotWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
