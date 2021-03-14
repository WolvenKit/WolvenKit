using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldListResource : CResource
	{
		private CArray<worldWorldListResourceEntry> _worlds;

		[Ordinal(1)] 
		[RED("worlds")] 
		public CArray<worldWorldListResourceEntry> Worlds
		{
			get
			{
				if (_worlds == null)
				{
					_worlds = (CArray<worldWorldListResourceEntry>) CR2WTypeManager.Create("array:worldWorldListResourceEntry", "worlds", cr2w, this);
				}
				return _worlds;
			}
			set
			{
				if (_worlds == value)
				{
					return;
				}
				_worlds = value;
				PropertySet(this);
			}
		}

		public worldWorldListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
