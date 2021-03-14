using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InterestingFactsListenersIds : CVariable
	{
		private CUInt32 _zone;

		[Ordinal(0)] 
		[RED("zone")] 
		public CUInt32 Zone
		{
			get
			{
				if (_zone == null)
				{
					_zone = (CUInt32) CR2WTypeManager.Create("Uint32", "zone", cr2w, this);
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

		public InterestingFactsListenersIds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
