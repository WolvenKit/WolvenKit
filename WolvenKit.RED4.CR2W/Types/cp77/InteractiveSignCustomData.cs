using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignCustomData : WidgetCustomData
	{
		private CString _messege;
		private CEnum<SignShape> _signShape;

		[Ordinal(0)] 
		[RED("messege")] 
		public CString Messege
		{
			get
			{
				if (_messege == null)
				{
					_messege = (CString) CR2WTypeManager.Create("String", "messege", cr2w, this);
				}
				return _messege;
			}
			set
			{
				if (_messege == value)
				{
					return;
				}
				_messege = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get
			{
				if (_signShape == null)
				{
					_signShape = (CEnum<SignShape>) CR2WTypeManager.Create("SignShape", "signShape", cr2w, this);
				}
				return _signShape;
			}
			set
			{
				if (_signShape == value)
				{
					return;
				}
				_signShape = value;
				PropertySet(this);
			}
		}

		public InteractiveSignCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
