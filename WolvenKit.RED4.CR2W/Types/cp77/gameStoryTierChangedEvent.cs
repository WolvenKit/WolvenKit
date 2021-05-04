using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStoryTierChangedEvent : AIAIEvent
	{
		private CEnum<gameStoryTier> _newTier;

		[Ordinal(2)] 
		[RED("newTier")] 
		public CEnum<gameStoryTier> NewTier
		{
			get => GetProperty(ref _newTier);
			set => SetProperty(ref _newTier, value);
		}

		public gameStoryTierChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
