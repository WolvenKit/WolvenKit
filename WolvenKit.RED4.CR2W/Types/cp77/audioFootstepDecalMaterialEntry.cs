using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialEntry : CVariable
	{
		private CName _materialTag;
		private CHandle<audioLocomotionStateEventDictionary> _eventsByLocomotionState;

		[Ordinal(0)] 
		[RED("materialTag")] 
		public CName MaterialTag
		{
			get
			{
				if (_materialTag == null)
				{
					_materialTag = (CName) CR2WTypeManager.Create("CName", "materialTag", cr2w, this);
				}
				return _materialTag;
			}
			set
			{
				if (_materialTag == value)
				{
					return;
				}
				_materialTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eventsByLocomotionState")] 
		public CHandle<audioLocomotionStateEventDictionary> EventsByLocomotionState
		{
			get
			{
				if (_eventsByLocomotionState == null)
				{
					_eventsByLocomotionState = (CHandle<audioLocomotionStateEventDictionary>) CR2WTypeManager.Create("handle:audioLocomotionStateEventDictionary", "eventsByLocomotionState", cr2w, this);
				}
				return _eventsByLocomotionState;
			}
			set
			{
				if (_eventsByLocomotionState == value)
				{
					return;
				}
				_eventsByLocomotionState = value;
				PropertySet(this);
			}
		}

		public audioFootstepDecalMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
