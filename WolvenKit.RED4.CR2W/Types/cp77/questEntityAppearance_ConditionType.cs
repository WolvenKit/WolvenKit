using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityAppearance_ConditionType : questIEntityConditionType
	{
		private gameEntityReference _entityRef;
		private CName _appearance;

		[Ordinal(0)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get
			{
				if (_entityRef == null)
				{
					_entityRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityRef", cr2w, this);
				}
				return _entityRef;
			}
			set
			{
				if (_entityRef == value)
				{
					return;
				}
				_entityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get
			{
				if (_appearance == null)
				{
					_appearance = (CName) CR2WTypeManager.Create("CName", "appearance", cr2w, this);
				}
				return _appearance;
			}
			set
			{
				if (_appearance == value)
				{
					return;
				}
				_appearance = value;
				PropertySet(this);
			}
		}

		public questEntityAppearance_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
