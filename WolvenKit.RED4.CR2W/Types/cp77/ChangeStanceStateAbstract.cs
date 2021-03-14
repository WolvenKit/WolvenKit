using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeStanceStateAbstract : AIbehaviortaskScript
	{
		private CBool _changeStateOnDeactivate;

		[Ordinal(0)] 
		[RED("changeStateOnDeactivate")] 
		public CBool ChangeStateOnDeactivate
		{
			get
			{
				if (_changeStateOnDeactivate == null)
				{
					_changeStateOnDeactivate = (CBool) CR2WTypeManager.Create("Bool", "changeStateOnDeactivate", cr2w, this);
				}
				return _changeStateOnDeactivate;
			}
			set
			{
				if (_changeStateOnDeactivate == value)
				{
					return;
				}
				_changeStateOnDeactivate = value;
				PropertySet(this);
			}
		}

		public ChangeStanceStateAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
