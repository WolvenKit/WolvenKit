using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LookAtData : CVariable
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

		public LookAtData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
