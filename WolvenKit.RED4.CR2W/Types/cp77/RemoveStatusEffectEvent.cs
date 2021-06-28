using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveStatusEffectEvent : redEvent
	{
		private TweakDBID _effectID;
		private CUInt32 _removeCount;

		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get => GetProperty(ref _effectID);
			set => SetProperty(ref _effectID, value);
		}

		[Ordinal(1)] 
		[RED("removeCount")] 
		public CUInt32 RemoveCount
		{
			get => GetProperty(ref _removeCount);
			set => SetProperty(ref _removeCount, value);
		}

		public RemoveStatusEffectEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
