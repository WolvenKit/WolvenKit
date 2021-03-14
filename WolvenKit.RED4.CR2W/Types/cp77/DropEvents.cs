using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropEvents : CarriedObjectEvents
	{
		private CBool _ragdollReenabled;

		[Ordinal(9)] 
		[RED("ragdollReenabled")] 
		public CBool RagdollReenabled
		{
			get
			{
				if (_ragdollReenabled == null)
				{
					_ragdollReenabled = (CBool) CR2WTypeManager.Create("Bool", "ragdollReenabled", cr2w, this);
				}
				return _ragdollReenabled;
			}
			set
			{
				if (_ragdollReenabled == value)
				{
					return;
				}
				_ragdollReenabled = value;
				PropertySet(this);
			}
		}

		public DropEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
