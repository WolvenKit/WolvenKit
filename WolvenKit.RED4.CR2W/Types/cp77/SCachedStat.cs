using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCachedStat : CVariable
	{
		private CEnum<gamedataStatType> _stat;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public SCachedStat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
