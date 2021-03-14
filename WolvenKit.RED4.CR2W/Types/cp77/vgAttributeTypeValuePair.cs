using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgAttributeTypeValuePair : ISerializable
	{
		private CEnum<vgEStyleAttributeType> _pe;
		private CVariant _lue;

		[Ordinal(0)] 
		[RED("pe")] 
		public CEnum<vgEStyleAttributeType> Pe
		{
			get
			{
				if (_pe == null)
				{
					_pe = (CEnum<vgEStyleAttributeType>) CR2WTypeManager.Create("vgEStyleAttributeType", "pe", cr2w, this);
				}
				return _pe;
			}
			set
			{
				if (_pe == value)
				{
					return;
				}
				_pe = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lue")] 
		public CVariant Lue
		{
			get
			{
				if (_lue == null)
				{
					_lue = (CVariant) CR2WTypeManager.Create("Variant", "lue", cr2w, this);
				}
				return _lue;
			}
			set
			{
				if (_lue == value)
				{
					return;
				}
				_lue = value;
				PropertySet(this);
			}
		}

		public vgAttributeTypeValuePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
