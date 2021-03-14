using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class previewTargetStruct : CVariable
	{
		private wCHandle<gameObject> _currentlyTrackedTarget;
		private CEnum<EHitReactionZone> _currentBodyPart;

		[Ordinal(0)] 
		[RED("currentlyTrackedTarget")] 
		public wCHandle<gameObject> CurrentlyTrackedTarget
		{
			get
			{
				if (_currentlyTrackedTarget == null)
				{
					_currentlyTrackedTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "currentlyTrackedTarget", cr2w, this);
				}
				return _currentlyTrackedTarget;
			}
			set
			{
				if (_currentlyTrackedTarget == value)
				{
					return;
				}
				_currentlyTrackedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentBodyPart")] 
		public CEnum<EHitReactionZone> CurrentBodyPart
		{
			get
			{
				if (_currentBodyPart == null)
				{
					_currentBodyPart = (CEnum<EHitReactionZone>) CR2WTypeManager.Create("EHitReactionZone", "currentBodyPart", cr2w, this);
				}
				return _currentBodyPart;
			}
			set
			{
				if (_currentBodyPart == value)
				{
					return;
				}
				_currentBodyPart = value;
				PropertySet(this);
			}
		}

		public previewTargetStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
