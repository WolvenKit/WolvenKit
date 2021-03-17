using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperations : DeviceOperations
	{
		private CArray<SInteractionAreaOperationData> _interactionAreaOperations;

		[Ordinal(2)] 
		[RED("interactionAreaOperations")] 
		public CArray<SInteractionAreaOperationData> InteractionAreaOperations_
		{
			get => GetProperty(ref _interactionAreaOperations);
			set => SetProperty(ref _interactionAreaOperations, value);
		}

		public InteractionAreaOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
