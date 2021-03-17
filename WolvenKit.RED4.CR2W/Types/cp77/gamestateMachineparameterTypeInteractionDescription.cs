using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeInteractionDescription : IScriptable
	{
		private wCHandle<entEntity> _interactionEntity;
		private CName _interactionType;

		[Ordinal(0)] 
		[RED("interactionEntity")] 
		public wCHandle<entEntity> InteractionEntity
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

		public gamestateMachineparameterTypeInteractionDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
