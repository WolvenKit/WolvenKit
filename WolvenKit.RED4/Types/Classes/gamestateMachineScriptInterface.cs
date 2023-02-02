using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineScriptInterface : IScriptable
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("localBlackboard")] 
		public CWeakHandle<gameIBlackboard> LocalBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(3)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("executionOwnerEntityID")] 
		public entEntityID ExecutionOwnerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(5)] 
		[RED("stateMachineBBDef")] 
		public CHandle<gamebbScriptDefinition> StateMachineBBDef
		{
			get => GetPropertyValue<CHandle<gamebbScriptDefinition>>();
			set => SetPropertyValue<CHandle<gamebbScriptDefinition>>(value);
		}

		public gamestateMachineScriptInterface()
		{
			OwnerEntityID = new();
			ExecutionOwnerEntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
