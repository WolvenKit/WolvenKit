using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questWeather_ConditionType : questISystemConditionType
	{
		private CName _weather;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("weather")] 
		public CName Weather
		{
			get => GetProperty(ref _weather);
			set => SetProperty(ref _weather, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questWeather_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
