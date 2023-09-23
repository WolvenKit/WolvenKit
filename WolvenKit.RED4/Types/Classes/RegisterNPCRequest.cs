using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterNPCRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		public RegisterNPCRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
