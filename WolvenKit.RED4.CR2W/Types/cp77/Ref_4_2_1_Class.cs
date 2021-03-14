using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_2_1_Class : IScriptable
	{
		private CInt32 _constValue;

		[Ordinal(0)] 
		[RED("constValue")] 
		public CInt32 ConstValue
		{
			get
			{
				if (_constValue == null)
				{
					_constValue = (CInt32) CR2WTypeManager.Create("Int32", "constValue", cr2w, this);
				}
				return _constValue;
			}
			set
			{
				if (_constValue == value)
				{
					return;
				}
				_constValue = value;
				PropertySet(this);
			}
		}

		public Ref_4_2_1_Class(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
