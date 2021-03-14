using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LookAtPresetBaseEvents : DefaultTransition
	{
		private CArray<CHandle<entLookAtAddEvent>> _lookAtEvents;
		private CBool _attachLeft;
		private CBool _attachRight;

		[Ordinal(0)] 
		[RED("lookAtEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> LookAtEvents
		{
			get
			{
				if (_lookAtEvents == null)
				{
					_lookAtEvents = (CArray<CHandle<entLookAtAddEvent>>) CR2WTypeManager.Create("array:handle:entLookAtAddEvent", "lookAtEvents", cr2w, this);
				}
				return _lookAtEvents;
			}
			set
			{
				if (_lookAtEvents == value)
				{
					return;
				}
				_lookAtEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attachLeft")] 
		public CBool AttachLeft
		{
			get
			{
				if (_attachLeft == null)
				{
					_attachLeft = (CBool) CR2WTypeManager.Create("Bool", "attachLeft", cr2w, this);
				}
				return _attachLeft;
			}
			set
			{
				if (_attachLeft == value)
				{
					return;
				}
				_attachLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attachRight")] 
		public CBool AttachRight
		{
			get
			{
				if (_attachRight == null)
				{
					_attachRight = (CBool) CR2WTypeManager.Create("Bool", "attachRight", cr2w, this);
				}
				return _attachRight;
			}
			set
			{
				if (_attachRight == value)
				{
					return;
				}
				_attachRight = value;
				PropertySet(this);
			}
		}

		public LookAtPresetBaseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
