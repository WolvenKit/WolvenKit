using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrentStanceNPCStatePrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataNPCStanceState> _valueToCheck;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("valueToCheck")] 
		public CEnum<gamedataNPCStanceState> ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public CurrentStanceNPCStatePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
