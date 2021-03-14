using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTransfromAnim : InteractiveDevice
	{
		private CInt32 _animationState;

		[Ordinal(93)] 
		[RED("animationState")] 
		public CInt32 AnimationState
		{
			get
			{
				if (_animationState == null)
				{
					_animationState = (CInt32) CR2WTypeManager.Create("Int32", "animationState", cr2w, this);
				}
				return _animationState;
			}
			set
			{
				if (_animationState == value)
				{
					return;
				}
				_animationState = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceTransfromAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
