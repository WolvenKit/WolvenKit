using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentManipulationRequest : IScriptable
	{
		private CEnum<EquipmentManipulationRequestType> _requestType;
		private CEnum<EquipmentManipulationRequestSlot> _requestSlot;
		private CEnum<gameEquipAnimationType> _equipAnim;

		[Ordinal(0)] 
		[RED("requestType")] 
		public CEnum<EquipmentManipulationRequestType> RequestType
		{
			get
			{
				if (_requestType == null)
				{
					_requestType = (CEnum<EquipmentManipulationRequestType>) CR2WTypeManager.Create("EquipmentManipulationRequestType", "requestType", cr2w, this);
				}
				return _requestType;
			}
			set
			{
				if (_requestType == value)
				{
					return;
				}
				_requestType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requestSlot")] 
		public CEnum<EquipmentManipulationRequestSlot> RequestSlot
		{
			get
			{
				if (_requestSlot == null)
				{
					_requestSlot = (CEnum<EquipmentManipulationRequestSlot>) CR2WTypeManager.Create("EquipmentManipulationRequestSlot", "requestSlot", cr2w, this);
				}
				return _requestSlot;
			}
			set
			{
				if (_requestSlot == value)
				{
					return;
				}
				_requestSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("equipAnim")] 
		public CEnum<gameEquipAnimationType> EquipAnim
		{
			get
			{
				if (_equipAnim == null)
				{
					_equipAnim = (CEnum<gameEquipAnimationType>) CR2WTypeManager.Create("gameEquipAnimationType", "equipAnim", cr2w, this);
				}
				return _equipAnim;
			}
			set
			{
				if (_equipAnim == value)
				{
					return;
				}
				_equipAnim = value;
				PropertySet(this);
			}
		}

		public EquipmentManipulationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
