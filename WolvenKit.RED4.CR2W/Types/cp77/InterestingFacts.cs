using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InterestingFacts : CVariable
	{
		private CName _zone;

		[Ordinal(0)] 
		[RED("zone")] 
		public CName Zone
		{
			get
			{
				if (_zone == null)
				{
					_zone = (CName) CR2WTypeManager.Create("CName", "zone", cr2w, this);
				}
				return _zone;
			}
			set
			{
				if (_zone == value)
				{
					return;
				}
				_zone = value;
				PropertySet(this);
			}
		}

		public InterestingFacts(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
