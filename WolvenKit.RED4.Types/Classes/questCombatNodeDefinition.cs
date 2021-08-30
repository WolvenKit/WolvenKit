using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCombatNodeDefinition : questConfigurableAICommandNode
	{
		private gameEntityReference _entityReference;
		private CName _function;
		private CHandle<questAICommandParams> _params;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(3)] 
		[RED("function")] 
		public CName Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		[Ordinal(4)] 
		[RED("params")] 
		public CHandle<questAICommandParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questCombatNodeDefinition()
		{
			_function = "questCombatNodeParams_ShootAt";
		}
	}
}
