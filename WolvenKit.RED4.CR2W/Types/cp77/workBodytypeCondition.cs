using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workBodytypeCondition : workIWorkspotCondition
	{
		private raRef<animRig> _rig;

		[Ordinal(2)] 
		[RED("rig")] 
		public raRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (raRef<animRig>) CR2WTypeManager.Create("raRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		public workBodytypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
