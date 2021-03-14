using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayData : BasePerkDisplayData
	{
		private CEnum<gamedataPerkArea> _area;
		private CEnum<gamedataPerkType> _type;

		[Ordinal(10)] 
		[RED("area")] 
		public CEnum<gamedataPerkArea> Area
		{
			get
			{
				if (_area == null)
				{
					_area = (CEnum<gamedataPerkArea>) CR2WTypeManager.Create("gamedataPerkArea", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<gamedataPerkType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataPerkType>) CR2WTypeManager.Create("gamedataPerkType", "type", cr2w, this);
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

		public PerkDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
