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
			get
			{
				if (_interactionAreaOperations == null)
				{
					_interactionAreaOperations = (CArray<SInteractionAreaOperationData>) CR2WTypeManager.Create("array:SInteractionAreaOperationData", "interactionAreaOperations", cr2w, this);
				}
				return _interactionAreaOperations;
			}
			set
			{
				if (_interactionAreaOperations == value)
				{
					return;
				}
				_interactionAreaOperations = value;
				PropertySet(this);
			}
		}

		public InteractionAreaOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
