using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_4_1_Class : IScriptable
	{
		private CInt32 _intProp;

		[Ordinal(0)] 
		[RED("intProp")] 
		public CInt32 IntProp
		{
			get
			{
				if (_intProp == null)
				{
					_intProp = (CInt32) CR2WTypeManager.Create("Int32", "intProp", cr2w, this);
				}
				return _intProp;
			}
			set
			{
				if (_intProp == value)
				{
					return;
				}
				_intProp = value;
				PropertySet(this);
			}
		}

		public Ref_1_4_1_Class(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
