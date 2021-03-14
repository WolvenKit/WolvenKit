using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TraitDisplayData : BasePerkDisplayData
	{
		private CEnum<gamedataTraitType> _type;

		[Ordinal(10)] 
		[RED("type")] 
		public CEnum<gamedataTraitType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataTraitType>) CR2WTypeManager.Create("gamedataTraitType", "type", cr2w, this);
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

		public TraitDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
