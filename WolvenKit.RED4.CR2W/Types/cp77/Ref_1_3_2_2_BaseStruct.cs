using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_2_BaseStruct : CVariable
	{
		private CInt32 _prop1;

		[Ordinal(0)] 
		[RED("prop1")] 
		public CInt32 Prop1
		{
			get
			{
				if (_prop1 == null)
				{
					_prop1 = (CInt32) CR2WTypeManager.Create("Int32", "prop1", cr2w, this);
				}
				return _prop1;
			}
			set
			{
				if (_prop1 == value)
				{
					return;
				}
				_prop1 = value;
				PropertySet(this);
			}
		}

		public Ref_1_3_2_2_BaseStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
