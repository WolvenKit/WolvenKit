using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInteriorAreaNotifier : worldITriggerAreaNotifer
	{
		private CArray<TweakDBID> _gameRestrictionIDs;
		private CBool _treatAsInterior;
		private CBool _setTier2;

		[Ordinal(3)] 
		[RED("gameRestrictionIDs")] 
		public CArray<TweakDBID> GameRestrictionIDs
		{
			get => GetProperty(ref _gameRestrictionIDs);
			set => SetProperty(ref _gameRestrictionIDs, value);
		}

		[Ordinal(4)] 
		[RED("treatAsInterior")] 
		public CBool TreatAsInterior
		{
			get => GetProperty(ref _treatAsInterior);
			set => SetProperty(ref _treatAsInterior, value);
		}

		[Ordinal(5)] 
		[RED("setTier2")] 
		public CBool SetTier2
		{
			get => GetProperty(ref _setTier2);
			set => SetProperty(ref _setTier2, value);
		}

		public worldInteriorAreaNotifier(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
