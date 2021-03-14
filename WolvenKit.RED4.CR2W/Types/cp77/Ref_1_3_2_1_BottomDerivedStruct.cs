using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_1_BottomDerivedStruct : Ref_1_3_2_1_DerivedStruct
	{
		private CBool _bottomDerivedProp;

		[Ordinal(2)] 
		[RED("bottomDerivedProp")] 
		public CBool BottomDerivedProp
		{
			get
			{
				if (_bottomDerivedProp == null)
				{
					_bottomDerivedProp = (CBool) CR2WTypeManager.Create("Bool", "bottomDerivedProp", cr2w, this);
				}
				return _bottomDerivedProp;
			}
			set
			{
				if (_bottomDerivedProp == value)
				{
					return;
				}
				_bottomDerivedProp = value;
				PropertySet(this);
			}
		}

		public Ref_1_3_2_1_BottomDerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
