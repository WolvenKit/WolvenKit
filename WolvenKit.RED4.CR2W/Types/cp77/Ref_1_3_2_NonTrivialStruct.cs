using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_NonTrivialStruct : CVariable
	{
		private CFloat _prop1;
		private Ref_1_3_2_TrivialStruct _prop2;

		[Ordinal(0)] 
		[RED("prop1")] 
		public CFloat Prop1
		{
			get
			{
				if (_prop1 == null)
				{
					_prop1 = (CFloat) CR2WTypeManager.Create("Float", "prop1", cr2w, this);
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

		[Ordinal(1)] 
		[RED("prop2")] 
		public Ref_1_3_2_TrivialStruct Prop2
		{
			get
			{
				if (_prop2 == null)
				{
					_prop2 = (Ref_1_3_2_TrivialStruct) CR2WTypeManager.Create("Ref_1_3_2_TrivialStruct", "prop2", cr2w, this);
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

		public Ref_1_3_2_NonTrivialStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
