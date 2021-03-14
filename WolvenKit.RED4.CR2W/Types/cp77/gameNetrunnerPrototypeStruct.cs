using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeStruct : CVariable
	{
		private CName _key;
		private raRef<entEntityTemplate> _entityTemplate;

		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get
			{
				if (_key == null)
				{
					_key = (CName) CR2WTypeManager.Create("CName", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityTemplate")] 
		public raRef<entEntityTemplate> EntityTemplate
		{
			get
			{
				if (_entityTemplate == null)
				{
					_entityTemplate = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "entityTemplate", cr2w, this);
				}
				return _entityTemplate;
			}
			set
			{
				if (_entityTemplate == value)
				{
					return;
				}
				_entityTemplate = value;
				PropertySet(this);
			}
		}

		public gameNetrunnerPrototypeStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
