using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterUnitRequest : gameScriptableSystemRequest
	{
		private CWeakHandle<ScriptedPuppet> _unit;

		[Ordinal(0)] 
		[RED("unit")] 
		public CWeakHandle<ScriptedPuppet> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}
	}
}
