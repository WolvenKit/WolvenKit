using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNodeDefinition : graphGraphNodeDefinition
	{
		private CUInt16 _id;

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt16) CR2WTypeManager.Create("Uint16", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public questNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
