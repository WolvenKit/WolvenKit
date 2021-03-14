using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapperSource : CVariable
	{
		private CEnum<entVertexAnimationMapperSourceType> _type;
		private CName _name;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<entVertexAnimationMapperSourceType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<entVertexAnimationMapperSourceType>) CR2WTypeManager.Create("entVertexAnimationMapperSourceType", "type", cr2w, this);
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

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		public entVertexAnimationMapperSource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
