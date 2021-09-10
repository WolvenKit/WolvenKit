using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterUnitRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("unit")] 
		public CWeakHandle<ScriptedPuppet> Unit
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}
	}
}
