using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddSubCharacterRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("subCharObject")] 
		public CWeakHandle<ScriptedPuppet> SubCharObject
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}
	}
}
