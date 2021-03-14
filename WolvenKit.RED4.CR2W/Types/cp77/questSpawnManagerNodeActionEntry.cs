using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeActionEntry : CVariable
	{
		private CHandle<questSpawnManagerNodeType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questSpawnManagerNodeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questSpawnManagerNodeType>) CR2WTypeManager.Create("handle:questSpawnManagerNodeType", "type", cr2w, this);
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

		public questSpawnManagerNodeActionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
