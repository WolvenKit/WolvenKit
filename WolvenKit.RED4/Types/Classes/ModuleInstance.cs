using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModuleInstance : IScriptable
	{
		[Ordinal(0)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("wasProcessed")] 
		public CBool WasProcessed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("state")] 
		public CEnum<InstanceState> State
		{
			get => GetPropertyValue<CEnum<InstanceState>>();
			set => SetPropertyValue<CEnum<InstanceState>>(value);
		}

		[Ordinal(5)] 
		[RED("previousInstance")] 
		public CHandle<ModuleInstance> PreviousInstance
		{
			get => GetPropertyValue<CHandle<ModuleInstance>>();
			set => SetPropertyValue<CHandle<ModuleInstance>>(value);
		}

		public ModuleInstance()
		{
			EntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
