using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamebbID : CVariable
	{
		private CName _g;

		[Ordinal(0)] 
		[RED("g")] 
		public CName G
		{
			get
			{
				if (_g == null)
				{
					_g = (CName) CR2WTypeManager.Create("CName", "g", cr2w, this);
				}
				return _g;
			}
			set
			{
				if (_g == value)
				{
					return;
				}
				_g = value;
				PropertySet(this);
			}
		}

		public gamebbID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
