using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_1_DerivedStruct : Ref_1_3_2_1_BaseStruct
	{
		private CFloat _derivedProp;

		[Ordinal(1)] 
		[RED("derivedProp")] 
		public CFloat DerivedProp
		{
			get
			{
				if (_derivedProp == null)
				{
					_derivedProp = (CFloat) CR2WTypeManager.Create("Float", "derivedProp", cr2w, this);
				}
				return _derivedProp;
			}
			set
			{
				if (_derivedProp == value)
				{
					return;
				}
				_derivedProp = value;
				PropertySet(this);
			}
		}

		public Ref_1_3_2_1_DerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
