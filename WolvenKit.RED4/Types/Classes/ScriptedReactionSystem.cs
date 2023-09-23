using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScriptedReactionSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("fleeingNPCs")] 
		public CInt32 FleeingNPCs
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("runners")] 
		public CArray<CWeakHandle<entEntity>> Runners
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		[Ordinal(2)] 
		[RED("registeredTimeout")] 
		public CFloat RegisteredTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("callInAction")] 
		public CBool CallInAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("policeCaller")] 
		public CWeakHandle<entEntity> PoliceCaller
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public ScriptedReactionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
