using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpdateEvent : redEvent
	{
		private CInt32 _lvl;
		private CEnum<gamedataProficiencyType> _type;
		private CArray<SDevelopmentPoints> _devPoints;

		[Ordinal(0)] 
		[RED("lvl")] 
		public CInt32 Lvl
		{
			get => GetProperty(ref _lvl);
			set => SetProperty(ref _lvl, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("devPoints")] 
		public CArray<SDevelopmentPoints> DevPoints
		{
			get => GetProperty(ref _devPoints);
			set => SetProperty(ref _devPoints, value);
		}

		public LevelUpdateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
