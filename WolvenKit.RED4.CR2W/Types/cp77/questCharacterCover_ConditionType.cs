using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterCover_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _puppetRef;
		private NodeRef _coverRef;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("coverRef")] 
		public NodeRef CoverRef
		{
			get
			{
				if (_coverRef == null)
				{
					_coverRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "coverRef", cr2w, this);
				}
				return _coverRef;
			}
			set
			{
				if (_coverRef == value)
				{
					return;
				}
				_coverRef = value;
				PropertySet(this);
			}
		}

		public questCharacterCover_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
