using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LookAtData : RedBaseClass
	{
		private CInt32 _idle;
		private CInt32 _category;
		private CEnum<gamedataStatType> _personality;

		[Ordinal(0)] 
		[RED("idle")] 
		public CInt32 Idle
		{
			get => GetProperty(ref _idle);
			set => SetProperty(ref _idle, value);
		}

		[Ordinal(1)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(2)] 
		[RED("personality")] 
		public CEnum<gamedataStatType> Personality
		{
			get => GetProperty(ref _personality);
			set => SetProperty(ref _personality, value);
		}
	}
}
