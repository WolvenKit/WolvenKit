using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EquipmentInitData : IScriptable
	{
		private CName _eqManipulationVarName;

		[Ordinal(0)] 
		[RED("eqManipulationVarName")] 
		public CName EqManipulationVarName
		{
			get => GetProperty(ref _eqManipulationVarName);
			set => SetProperty(ref _eqManipulationVarName, value);
		}
	}
}
