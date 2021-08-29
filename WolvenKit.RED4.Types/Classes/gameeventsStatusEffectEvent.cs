using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsStatusEffectEvent : redEvent
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
	}
}
