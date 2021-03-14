using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrappleStandEvents : LocomotionTakedownEvents
	{
		private CBool _isWalking;

		[Ordinal(1)] 
		[RED("isWalking")] 
		public CBool IsWalking
		{
			get
			{
				if (_isWalking == null)
				{
					_isWalking = (CBool) CR2WTypeManager.Create("Bool", "isWalking", cr2w, this);
				}
				return _isWalking;
			}
			set
			{
				if (_isWalking == value)
				{
					return;
				}
				_isWalking = value;
				PropertySet(this);
			}
		}

		public GrappleStandEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
