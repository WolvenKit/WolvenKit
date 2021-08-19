using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_PlayerIgnoreFriendlyAndAlive : gameEffectObjectGroupFilter
	{
		private TweakDBID _ignoreCharacterRecord;

		[Ordinal(0)] 
		[RED("ignoreCharacterRecord")] 
		public TweakDBID IgnoreCharacterRecord
		{
			get => GetProperty(ref _ignoreCharacterRecord);
			set => SetProperty(ref _ignoreCharacterRecord, value);
		}

		public gameEffectObjectFilter_PlayerIgnoreFriendlyAndAlive(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
