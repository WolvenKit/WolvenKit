using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetChancePrereq : gameIScriptablePrereq
	{
		private CFloat _setChance;

		[Ordinal(0)] 
		[RED("setChance")] 
		public CFloat SetChance
		{
			get => GetProperty(ref _setChance);
			set => SetProperty(ref _setChance, value);
		}

		public SetChancePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
