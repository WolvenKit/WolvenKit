using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckArgumentBoolean : CheckArguments
	{
		private CBool _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CBool CustomVar
		{
			get
			{
				if (_customVar == null)
				{
					_customVar = (CBool) CR2WTypeManager.Create("Bool", "customVar", cr2w, this);
				}
				return _customVar;
			}
			set
			{
				if (_customVar == value)
				{
					return;
				}
				_customVar = value;
				PropertySet(this);
			}
		}

		public CheckArgumentBoolean(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
