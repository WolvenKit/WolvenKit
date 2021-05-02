using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowSlotsComponent : gameScriptableComponent
	{
		private CArray<CHandle<FollowSlot>> _followSlots;

		[Ordinal(5)] 
		[RED("followSlots")] 
		public CArray<CHandle<FollowSlot>> FollowSlots
		{
			get => GetProperty(ref _followSlots);
			set => SetProperty(ref _followSlots, value);
		}

		public FollowSlotsComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
