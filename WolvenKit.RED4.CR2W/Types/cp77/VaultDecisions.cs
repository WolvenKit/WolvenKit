using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VaultDecisions : LocomotionGroundDecisions
	{
		private CBool _stateBodyDone;

		[Ordinal(0)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get
			{
				if (_stateBodyDone == null)
				{
					_stateBodyDone = (CBool) CR2WTypeManager.Create("Bool", "stateBodyDone", cr2w, this);
				}
				return _stateBodyDone;
			}
			set
			{
				if (_stateBodyDone == value)
				{
					return;
				}
				_stateBodyDone = value;
				PropertySet(this);
			}
		}

		public VaultDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
