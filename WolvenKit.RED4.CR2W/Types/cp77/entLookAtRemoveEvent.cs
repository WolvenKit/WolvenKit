using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLookAtRemoveEvent : redEvent
	{
		private animLookAtRef _lookAtRef;
		private CBool _hasOutTransition;
		private CFloat _outTransitionSpeed;

		[Ordinal(0)] 
		[RED("lookAtRef")] 
		public animLookAtRef LookAtRef
		{
			get
			{
				if (_lookAtRef == null)
				{
					_lookAtRef = (animLookAtRef) CR2WTypeManager.Create("animLookAtRef", "lookAtRef", cr2w, this);
				}
				return _lookAtRef;
			}
			set
			{
				if (_lookAtRef == value)
				{
					return;
				}
				_lookAtRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasOutTransition")] 
		public CBool HasOutTransition
		{
			get
			{
				if (_hasOutTransition == null)
				{
					_hasOutTransition = (CBool) CR2WTypeManager.Create("Bool", "hasOutTransition", cr2w, this);
				}
				return _hasOutTransition;
			}
			set
			{
				if (_hasOutTransition == value)
				{
					return;
				}
				_hasOutTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get
			{
				if (_outTransitionSpeed == null)
				{
					_outTransitionSpeed = (CFloat) CR2WTypeManager.Create("Float", "outTransitionSpeed", cr2w, this);
				}
				return _outTransitionSpeed;
			}
			set
			{
				if (_outTransitionSpeed == value)
				{
					return;
				}
				_outTransitionSpeed = value;
				PropertySet(this);
			}
		}

		public entLookAtRemoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
