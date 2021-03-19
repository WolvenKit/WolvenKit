using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageCacheData : IScriptable
	{
		private CEnum<gameGodModeType> _targetImmortalityMode;
		private CBool _tEMP_ImmortalityCached;
		private CInt64 _logFlags;

		[Ordinal(0)] 
		[RED("targetImmortalityMode")] 
		public CEnum<gameGodModeType> TargetImmortalityMode
		{
			get => GetProperty(ref _targetImmortalityMode);
			set => SetProperty(ref _targetImmortalityMode, value);
		}

		[Ordinal(1)] 
		[RED("TEMP_ImmortalityCached")] 
		public CBool TEMP_ImmortalityCached
		{
			get => GetProperty(ref _tEMP_ImmortalityCached);
			set => SetProperty(ref _tEMP_ImmortalityCached, value);
		}

		[Ordinal(2)] 
		[RED("logFlags")] 
		public CInt64 LogFlags
		{
			get => GetProperty(ref _logFlags);
			set => SetProperty(ref _logFlags, value);
		}

		public gamedamageCacheData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
