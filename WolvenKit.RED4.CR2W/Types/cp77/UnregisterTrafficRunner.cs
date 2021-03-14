using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterTrafficRunner : AIbehaviortaskScript
	{
		private CBool _onDeactivation;

		[Ordinal(0)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get
			{
				if (_onDeactivation == null)
				{
					_onDeactivation = (CBool) CR2WTypeManager.Create("Bool", "onDeactivation", cr2w, this);
				}
				return _onDeactivation;
			}
			set
			{
				if (_onDeactivation == value)
				{
					return;
				}
				_onDeactivation = value;
				PropertySet(this);
			}
		}

		public UnregisterTrafficRunner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
