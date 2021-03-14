using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowSlotDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _slotID;
		private gamebbScriptID_Variant _slotTransform;

		[Ordinal(0)] 
		[RED("slotID")] 
		public gamebbScriptID_Int32 SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotTransform")] 
		public gamebbScriptID_Variant SlotTransform
		{
			get
			{
				if (_slotTransform == null)
				{
					_slotTransform = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "slotTransform", cr2w, this);
				}
				return _slotTransform;
			}
			set
			{
				if (_slotTransform == value)
				{
					return;
				}
				_slotTransform = value;
				PropertySet(this);
			}
		}

		public AIFollowSlotDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
