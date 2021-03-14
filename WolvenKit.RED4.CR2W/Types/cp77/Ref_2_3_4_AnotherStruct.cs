using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_2_3_4_AnotherStruct : CVariable
	{
		private CFloat _val;

		[Ordinal(0)] 
		[RED("val")] 
		public CFloat Val
		{
			get
			{
				if (_val == null)
				{
					_val = (CFloat) CR2WTypeManager.Create("Float", "val", cr2w, this);
				}
				return _val;
			}
			set
			{
				if (_val == value)
				{
					return;
				}
				_val = value;
				PropertySet(this);
			}
		}

		public Ref_2_3_4_AnotherStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
