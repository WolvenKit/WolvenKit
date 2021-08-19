using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSubStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		private CEnum<gamedataStatType> _refStatType;

		[Ordinal(2)] 
		[RED("refStatType")] 
		public CEnum<gamedataStatType> RefStatType
		{
			get => GetProperty(ref _refStatType);
			set => SetProperty(ref _refStatType, value);
		}

		public gameSubStatModifierData_Deprecated(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
