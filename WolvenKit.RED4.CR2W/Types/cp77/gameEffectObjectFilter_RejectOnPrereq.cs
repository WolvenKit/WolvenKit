using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_RejectOnPrereq : gameEffectObjectSingleFilter
	{
		private CHandle<gameIPrereq> _prereq;

		[Ordinal(0)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get
			{
				if (_prereq == null)
				{
					_prereq = (CHandle<gameIPrereq>) CR2WTypeManager.Create("handle:gameIPrereq", "prereq", cr2w, this);
				}
				return _prereq;
			}
			set
			{
				if (_prereq == value)
				{
					return;
				}
				_prereq = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectFilter_RejectOnPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
