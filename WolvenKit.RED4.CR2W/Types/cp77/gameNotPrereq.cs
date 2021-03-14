using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNotPrereq : gameIPrereq
	{
		private CHandle<gameIPrereq> _negatedPrereq;

		[Ordinal(0)] 
		[RED("negatedPrereq")] 
		public CHandle<gameIPrereq> NegatedPrereq
		{
			get
			{
				if (_negatedPrereq == null)
				{
					_negatedPrereq = (CHandle<gameIPrereq>) CR2WTypeManager.Create("handle:gameIPrereq", "negatedPrereq", cr2w, this);
				}
				return _negatedPrereq;
			}
			set
			{
				if (_negatedPrereq == value)
				{
					return;
				}
				_negatedPrereq = value;
				PropertySet(this);
			}
		}

		public gameNotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
