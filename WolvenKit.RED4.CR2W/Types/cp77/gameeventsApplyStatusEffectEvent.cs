using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsApplyStatusEffectEvent : gameeventsStatusEffectEvent
	{
		private CBool _isNewApplication;
		private entEntityID _instigatorEntityID;
		private CBool _isAppliedOnSpawn;

		[Ordinal(2)] 
		[RED("isNewApplication")] 
		public CBool IsNewApplication
		{
			get => GetProperty(ref _isNewApplication);
			set => SetProperty(ref _isNewApplication, value);
		}

		[Ordinal(3)] 
		[RED("instigatorEntityID")] 
		public entEntityID InstigatorEntityID
		{
			get => GetProperty(ref _instigatorEntityID);
			set => SetProperty(ref _instigatorEntityID, value);
		}

		[Ordinal(4)] 
		[RED("isAppliedOnSpawn")] 
		public CBool IsAppliedOnSpawn
		{
			get => GetProperty(ref _isAppliedOnSpawn);
			set => SetProperty(ref _isAppliedOnSpawn, value);
		}

		public gameeventsApplyStatusEffectEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
