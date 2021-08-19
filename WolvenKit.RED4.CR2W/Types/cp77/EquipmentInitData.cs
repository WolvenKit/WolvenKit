using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentInitData : IScriptable
	{
		private CName _eqManipulationVarName;

		[Ordinal(0)] 
		[RED("eqManipulationVarName")] 
		public CName EqManipulationVarName
		{
			get => GetProperty(ref _eqManipulationVarName);
			set => SetProperty(ref _eqManipulationVarName, value);
		}

		public EquipmentInitData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
