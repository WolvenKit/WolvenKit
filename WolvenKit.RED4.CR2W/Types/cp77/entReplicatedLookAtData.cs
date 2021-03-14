using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedLookAtData : CVariable
	{
		private netTime _creationNetTime;

		[Ordinal(0)] 
		[RED("creationNetTime")] 
		public netTime CreationNetTime
		{
			get
			{
				if (_creationNetTime == null)
				{
					_creationNetTime = (netTime) CR2WTypeManager.Create("netTime", "creationNetTime", cr2w, this);
				}
				return _creationNetTime;
			}
			set
			{
				if (_creationNetTime == value)
				{
					return;
				}
				_creationNetTime = value;
				PropertySet(this);
			}
		}

		public entReplicatedLookAtData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
