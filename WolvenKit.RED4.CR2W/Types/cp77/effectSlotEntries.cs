using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectSlotEntries : effectIPlacementEntries
	{
		private CBool _inheritRotation;
		private CArray<effectSlotEntry> _slots;

		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get
			{
				if (_inheritRotation == null)
				{
					_inheritRotation = (CBool) CR2WTypeManager.Create("Bool", "inheritRotation", cr2w, this);
				}
				return _inheritRotation;
			}
			set
			{
				if (_inheritRotation == value)
				{
					return;
				}
				_inheritRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slots")] 
		public CArray<effectSlotEntry> Slots
		{
			get
			{
				if (_slots == null)
				{
					_slots = (CArray<effectSlotEntry>) CR2WTypeManager.Create("array:effectSlotEntry", "slots", cr2w, this);
				}
				return _slots;
			}
			set
			{
				if (_slots == value)
				{
					return;
				}
				_slots = value;
				PropertySet(this);
			}
		}

		public effectSlotEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
