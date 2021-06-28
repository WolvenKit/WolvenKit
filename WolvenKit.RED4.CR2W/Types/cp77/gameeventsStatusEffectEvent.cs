using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsStatusEffectEvent : redEvent
	{
		private CHandle<gamedataStatusEffect_Record> _staticData;
		private CUInt32 _stackCount;

		[Ordinal(0)] 
		[RED("staticData")] 
		public CHandle<gamedataStatusEffect_Record> StaticData
		{
			get => GetProperty(ref _staticData);
			set => SetProperty(ref _staticData, value);
		}

		[Ordinal(1)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get => GetProperty(ref _stackCount);
			set => SetProperty(ref _stackCount, value);
		}

		public gameeventsStatusEffectEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
