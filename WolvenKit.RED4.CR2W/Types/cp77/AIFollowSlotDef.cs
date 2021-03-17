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
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("slotTransform")] 
		public gamebbScriptID_Variant SlotTransform
		{
			get => GetProperty(ref _slotTransform);
			set => SetProperty(ref _slotTransform, value);
		}

		public AIFollowSlotDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
