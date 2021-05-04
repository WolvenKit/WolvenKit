using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterUnitRequest : gameScriptableSystemRequest
	{
		private wCHandle<ScriptedPuppet> _unit;

		[Ordinal(0)] 
		[RED("unit")] 
		public wCHandle<ScriptedPuppet> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		public RegisterUnitRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
