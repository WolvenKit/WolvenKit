using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_9 : CVariable
	{
		private CEnum<Sample_Enum_As_Bitfield_2_9> _bitField;

		[Ordinal(0)] 
		[RED("bitField")] 
		public CEnum<Sample_Enum_As_Bitfield_2_9> BitField
		{
			get
			{
				if (_bitField == null)
				{
					_bitField = (CEnum<Sample_Enum_As_Bitfield_2_9>) CR2WTypeManager.Create("Sample_Enum_As_Bitfield_2_9", "bitField", cr2w, this);
				}
				return _bitField;
			}
			set
			{
				if (_bitField == value)
				{
					return;
				}
				_bitField = value;
				PropertySet(this);
			}
		}

		public Sample_Class_2_9(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
