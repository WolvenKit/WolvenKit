using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Root_Object : CVariable
	{
		private CBool _bool;

		[Ordinal(0)] 
		[RED("bool")] 
		public CBool Bool
		{
			get
			{
				if (_bool == null)
				{
					_bool = (CBool) CR2WTypeManager.Create("Bool", "bool", cr2w, this);
				}
				return _bool;
			}
			set
			{
				if (_bool == value)
				{
					return;
				}
				_bool = value;
				PropertySet(this);
			}
		}

		public Sample_Replicated_Root_Object(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
