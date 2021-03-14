using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KnockOverBikeEvent : redEvent
	{
		private CBool _forceKnockdown;
		private CBool _applyDirectionalForce;

		[Ordinal(0)] 
		[RED("forceKnockdown")] 
		public CBool ForceKnockdown
		{
			get
			{
				if (_forceKnockdown == null)
				{
					_forceKnockdown = (CBool) CR2WTypeManager.Create("Bool", "forceKnockdown", cr2w, this);
				}
				return _forceKnockdown;
			}
			set
			{
				if (_forceKnockdown == value)
				{
					return;
				}
				_forceKnockdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("applyDirectionalForce")] 
		public CBool ApplyDirectionalForce
		{
			get
			{
				if (_applyDirectionalForce == null)
				{
					_applyDirectionalForce = (CBool) CR2WTypeManager.Create("Bool", "applyDirectionalForce", cr2w, this);
				}
				return _applyDirectionalForce;
			}
			set
			{
				if (_applyDirectionalForce == value)
				{
					return;
				}
				_applyDirectionalForce = value;
				PropertySet(this);
			}
		}

		public KnockOverBikeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
