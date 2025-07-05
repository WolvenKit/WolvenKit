using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MoveToCoverCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public CWeakHandle<AIMoveToCoverCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIMoveToCoverCommand>>();
			set => SetPropertyValue<CWeakHandle<AIMoveToCoverCommand>>(value);
		}

		[Ordinal(2)] 
		[RED("coverID")] 
		public CUInt64 CoverID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public MoveToCoverCommandTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
