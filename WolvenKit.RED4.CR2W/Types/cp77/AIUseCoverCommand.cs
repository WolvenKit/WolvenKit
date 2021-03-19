using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIUseCoverCommand : AICombatRelatedCommand
	{
		private NodeRef _coverNodeRef;
		private CBool _oneTimeSelection;
		private CName _forcedEntryAnimation;
		private CArray<CEnum<AICoverExposureMethod>> _exposureMethods;
		private CHandle<CoverCommandParams> _limitToTheseExposureMethods;

		[Ordinal(5)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get => GetProperty(ref _coverNodeRef);
			set => SetProperty(ref _coverNodeRef, value);
		}

		[Ordinal(6)] 
		[RED("oneTimeSelection")] 
		public CBool OneTimeSelection
		{
			get => GetProperty(ref _oneTimeSelection);
			set => SetProperty(ref _oneTimeSelection, value);
		}

		[Ordinal(7)] 
		[RED("forcedEntryAnimation")] 
		public CName ForcedEntryAnimation
		{
			get => GetProperty(ref _forcedEntryAnimation);
			set => SetProperty(ref _forcedEntryAnimation, value);
		}

		[Ordinal(8)] 
		[RED("exposureMethods")] 
		public CArray<CEnum<AICoverExposureMethod>> ExposureMethods
		{
			get => GetProperty(ref _exposureMethods);
			set => SetProperty(ref _exposureMethods, value);
		}

		[Ordinal(9)] 
		[RED("limitToTheseExposureMethods")] 
		public CHandle<CoverCommandParams> LimitToTheseExposureMethods
		{
			get => GetProperty(ref _limitToTheseExposureMethods);
			set => SetProperty(ref _limitToTheseExposureMethods, value);
		}

		public AIUseCoverCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
