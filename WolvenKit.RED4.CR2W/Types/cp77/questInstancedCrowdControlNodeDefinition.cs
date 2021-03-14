using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInstancedCrowdControlNodeDefinition : questDisableableNodeDefinition
	{
		private CName _crowdVariantTag;
		private CBool _enable;

		[Ordinal(2)] 
		[RED("crowdVariantTag")] 
		public CName CrowdVariantTag
		{
			get
			{
				if (_crowdVariantTag == null)
				{
					_crowdVariantTag = (CName) CR2WTypeManager.Create("CName", "crowdVariantTag", cr2w, this);
				}
				return _crowdVariantTag;
			}
			set
			{
				if (_crowdVariantTag == value)
				{
					return;
				}
				_crowdVariantTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		public questInstancedCrowdControlNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
