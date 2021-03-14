using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetArgumentFloat : SetArguments
	{
		private CFloat _customVar;

		[Ordinal(1)] 
		[RED("customVar")] 
		public CFloat CustomVar
		{
			get
			{
				if (_customVar == null)
				{
					_customVar = (CFloat) CR2WTypeManager.Create("Float", "customVar", cr2w, this);
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

		public SetArgumentFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
