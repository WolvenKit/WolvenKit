using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_1_BaseStruct : CVariable
	{
		private CInt32 _baseProp;

		[Ordinal(0)] 
		[RED("baseProp")] 
		public CInt32 BaseProp
		{
			get
			{
				if (_baseProp == null)
				{
					_baseProp = (CInt32) CR2WTypeManager.Create("Int32", "baseProp", cr2w, this);
				}
				return _baseProp;
			}
			set
			{
				if (_baseProp == value)
				{
					return;
				}
				_baseProp = value;
				PropertySet(this);
			}
		}

		public Ref_1_3_2_1_BaseStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
