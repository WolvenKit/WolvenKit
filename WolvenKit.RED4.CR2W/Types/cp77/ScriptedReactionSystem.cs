using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedReactionSystem : gameScriptableSystem
	{
		private CInt32 _fleeingNPCs;
		private CArray<wCHandle<entEntity>> _runners;
		private CFloat _registeredTimeout;
		private CBool _callInAction;
		private wCHandle<entEntity> _policeCaller;

		[Ordinal(0)] 
		[RED("fleeingNPCs")] 
		public CInt32 FleeingNPCs
		{
			get => GetProperty(ref _fleeingNPCs);
			set => SetProperty(ref _fleeingNPCs, value);
		}

		[Ordinal(1)] 
		[RED("runners")] 
		public CArray<wCHandle<entEntity>> Runners
		{
			get => GetProperty(ref _runners);
			set => SetProperty(ref _runners, value);
		}

		[Ordinal(2)] 
		[RED("registeredTimeout")] 
		public CFloat RegisteredTimeout
		{
			get => GetProperty(ref _registeredTimeout);
			set => SetProperty(ref _registeredTimeout, value);
		}

		[Ordinal(3)] 
		[RED("callInAction")] 
		public CBool CallInAction
		{
			get => GetProperty(ref _callInAction);
			set => SetProperty(ref _callInAction, value);
		}

		[Ordinal(4)] 
		[RED("policeCaller")] 
		public wCHandle<entEntity> PoliceCaller
		{
			get => GetProperty(ref _policeCaller);
			set => SetProperty(ref _policeCaller, value);
		}

		public ScriptedReactionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
