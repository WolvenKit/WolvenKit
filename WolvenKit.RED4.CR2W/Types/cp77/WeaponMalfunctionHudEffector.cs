using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponMalfunctionHudEffector : gameEffector
	{
		private CHandle<gameIBlackboard> _bb;

		[Ordinal(0)] 
		[RED("bb")] 
		public CHandle<gameIBlackboard> Bb
		{
			get
			{
				if (_bb == null)
				{
					_bb = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "bb", cr2w, this);
				}
				return _bb;
			}
			set
			{
				if (_bb == value)
				{
					return;
				}
				_bb = value;
				PropertySet(this);
			}
		}

		public WeaponMalfunctionHudEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
