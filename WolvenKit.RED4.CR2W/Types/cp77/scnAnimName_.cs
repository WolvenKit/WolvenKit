using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimName_ : ISerializable
	{
		private CEnum<scnAnimNameType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnAnimNameType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<scnAnimNameType>) CR2WTypeManager.Create("scnAnimNameType", "type", cr2w, this);
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

		public scnAnimName_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
