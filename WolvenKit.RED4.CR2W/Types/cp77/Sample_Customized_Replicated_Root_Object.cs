using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Customized_Replicated_Root_Object : Sample_Replicated_Root_Object
	{
		private CBool _bool2;

		[Ordinal(1)] 
		[RED("bool2")] 
		public CBool Bool2
		{
			get
			{
				if (_bool2 == null)
				{
					_bool2 = (CBool) CR2WTypeManager.Create("Bool", "bool2", cr2w, this);
				}
				return _bool2;
			}
			set
			{
				if (_bool2 == value)
				{
					return;
				}
				_bool2 = value;
				PropertySet(this);
			}
		}

		public Sample_Customized_Replicated_Root_Object(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
