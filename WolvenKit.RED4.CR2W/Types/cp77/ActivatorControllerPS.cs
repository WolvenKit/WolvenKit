using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatorControllerPS : MasterControllerPS
	{
		private CBool _hasSpiderbotInteraction;
		private NodeRef _spiderbotInteractionLocationOverride;
		private CBool _hasSimpleInteraction;
		private TweakDBID _alternativeInteractionName;
		private TweakDBID _alternativeSpiderbotInteractionName;
		private TweakDBID _alternativeQuickHackName;
		private CHandle<GenericContainer> _activatorSkillChecks;
		private CString _alternativeInteractionString;

		[Ordinal(104)] 
		[RED("hasSpiderbotInteraction")] 
		public CBool HasSpiderbotInteraction
		{
			get => GetProperty(ref _hasSpiderbotInteraction);
			set => SetProperty(ref _hasSpiderbotInteraction, value);
		}

		[Ordinal(105)] 
		[RED("spiderbotInteractionLocationOverride")] 
		public NodeRef SpiderbotInteractionLocationOverride
		{
			get => GetProperty(ref _spiderbotInteractionLocationOverride);
			set => SetProperty(ref _spiderbotInteractionLocationOverride, value);
		}

		[Ordinal(106)] 
		[RED("hasSimpleInteraction")] 
		public CBool HasSimpleInteraction
		{
			get => GetProperty(ref _hasSimpleInteraction);
			set => SetProperty(ref _hasSimpleInteraction, value);
		}

		[Ordinal(107)] 
		[RED("alternativeInteractionName")] 
		public TweakDBID AlternativeInteractionName
		{
			get => GetProperty(ref _alternativeInteractionName);
			set => SetProperty(ref _alternativeInteractionName, value);
		}

		[Ordinal(108)] 
		[RED("alternativeSpiderbotInteractionName")] 
		public TweakDBID AlternativeSpiderbotInteractionName
		{
			get => GetProperty(ref _alternativeSpiderbotInteractionName);
			set => SetProperty(ref _alternativeSpiderbotInteractionName, value);
		}

		[Ordinal(109)] 
		[RED("alternativeQuickHackName")] 
		public TweakDBID AlternativeQuickHackName
		{
			get => GetProperty(ref _alternativeQuickHackName);
			set => SetProperty(ref _alternativeQuickHackName, value);
		}

		[Ordinal(110)] 
		[RED("activatorSkillChecks")] 
		public CHandle<GenericContainer> ActivatorSkillChecks
		{
			get => GetProperty(ref _activatorSkillChecks);
			set => SetProperty(ref _activatorSkillChecks, value);
		}

		[Ordinal(111)] 
		[RED("alternativeInteractionString")] 
		public CString AlternativeInteractionString
		{
			get => GetProperty(ref _alternativeInteractionString);
			set => SetProperty(ref _alternativeInteractionString, value);
		}

		public ActivatorControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
