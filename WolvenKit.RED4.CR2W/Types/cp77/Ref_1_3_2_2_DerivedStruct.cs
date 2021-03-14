using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_2_DerivedStruct : Ref_1_3_2_2_BaseStruct
	{
		private CInt32 _prop2;

		[Ordinal(1)] 
		[RED("prop2")] 
		public CInt32 Prop2
		{
			get
			{
				if (_prop2 == null)
				{
					_prop2 = (CInt32) CR2WTypeManager.Create("Int32", "prop2", cr2w, this);
				}
				return _prop2;
			}
			set
			{
				if (_prop2 == value)
				{
					return;
				}
				_prop2 = value;
				PropertySet(this);
			}
		}

		public Ref_1_3_2_2_DerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
