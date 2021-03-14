using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpawnPointMarker : worldIMarker
	{
		private CUInt32 _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CUInt32 Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CUInt32) CR2WTypeManager.Create("Uint32", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public worldSpawnPointMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
