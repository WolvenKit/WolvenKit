using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimePeriod_ConditionType : questITimeConditionType
	{
		private GameTime _begin;
		private GameTime _end;

		[Ordinal(0)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get => GetProperty(ref _begin);
			set => SetProperty(ref _begin, value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public GameTime End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}

		public questTimePeriod_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
