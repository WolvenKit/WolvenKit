using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_DerivedStruct : Ref_1_3_2_NonTrivialStruct
	{
		private CBool _prop3;

		[Ordinal(2)] 
		[RED("prop3")] 
		public CBool Prop3
		{
			get
			{
				if (_prop3 == null)
				{
					_prop3 = (CBool) CR2WTypeManager.Create("Bool", "prop3", cr2w, this);
				}
				return _prop3;
			}
			set
			{
				if (_prop3 == value)
				{
					return;
				}
				_prop3 = value;
				PropertySet(this);
			}
		}

		public Ref_1_3_2_DerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
