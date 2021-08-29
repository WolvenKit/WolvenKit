using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineparameterTypeInteractionDescription : IScriptable
	{
		private CWeakHandle<entEntity> _interactionEntity;
		private CName _interactionType;

		[Ordinal(0)] 
		[RED("interactionEntity")] 
		public CWeakHandle<entEntity> InteractionEntity
		{
			get => GetProperty(ref _interactionEntity);
			set => SetProperty(ref _interactionEntity, value);
		}

		[Ordinal(1)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get => GetProperty(ref _interactionType);
			set => SetProperty(ref _interactionType, value);
		}
	}
}
